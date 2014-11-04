using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;
using TIL;
using DAL.Repositories;

namespace DAL
{
    public class BeneficioRepository : IRepository<Beneficio>
    {
        private string actividad;
        private static BeneficioRepository instance;
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        /// <summary>
        /// Es el constructor del repositorio.
        /// Instancia las listas de beneficios.
        /// </summary>
        /// <author>Mathias Muller</author>

        public BeneficioRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public static BeneficioRepository Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new BeneficioRepository() { };
                }
                return instance;
            }
        }

        /// <summary>
        /// Agrega un beneficio a la lista de insertar.
        /// </summary>
        /// <author>Mathias Muller</author>
        /// <returns>Una Liste de beneficios</returns>

        public void Insert(Beneficio entity)
        {
            _insertItems.Add(entity);
        }
        /// <summary>
        /// Agrega un beneficio a la lista de eliminar.
        /// </summary>
        /// <author>Mathias Muller</author>

        public void Delete(Beneficio entity)
        {
            _deleteItems.Add(entity);
        }

        /// <summary>
        /// Agrega un beneficio a la lista de editar.
        /// </summary>
        /// <author>Mathias Muller</author>

        public void Update(Beneficio entity)
        {
            _updateItems.Add(entity);
        }

        /// <summary>
        /// Trae un DataSet de la base de datos.
        /// Por cada DataRow en el DataSet, instancia un beneficio.
        /// </summary>
        /// <author>Mathias Muller</author>
        /// <returns>Una lista de beneficios</returns>

        public IEnumerable<Beneficio> GetAll()
        {
            try
            {

                List<Beneficio> listaBeneficios = null;
                var sqlQuery = "Sp_buscarBeneficios";
                SqlCommand cmd = new SqlCommand(sqlQuery);

                var ds = DBAccess.ExecuteQuery(cmd);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    listaBeneficios = new List<Beneficio>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        listaBeneficios.Add(new Beneficio
                        {
                            Id = Convert.ToInt32(dr["idBeneficio"]),
                            Nombre = dr["Nombre"].ToString(),
                            Porcentaje = Convert.ToDouble(dr["Porcentaje"]),
                            Aplicacion = dr["Aplicabilidad"].ToString()
                        });
                    }
                }

                return listaBeneficios;

            }
            catch (SqlException ex)
            {

                throw new CustomExceptions.DataAccessException("Ha ocurrido un error al Consultar todos los beneficios", ex);

            }
            
            catch (Exception e) {

                throw e;
            }
            
        }

        

        /// <summary>
        /// Trae un DataSet de la base de datos.
        /// Instancia un beneficio, con la información que recibe de la base de datos.
        /// El beneficio se busca por el nombre.
        /// </summary>
        /// <author>Mathias Muller</author>
        /// <param name="pnombre">Es el nombre del beneficio por el cual e va a busca1r en la base de datos</param>
        /// <returns>Un objeto beneficio</returns>

        public Beneficio GetById(int id)
        {
            Beneficio objBeneficio = new Beneficio();

            return objBeneficio;
        }

        public Beneficio GetByNombre(String pnombre)
        {

            try
            {
                Beneficio objBeneficio = null;
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@Nombre", pnombre));

                var ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarBeneficioPorNombre");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    var dr = ds.Tables[0].Rows[0];

                    objBeneficio = new Beneficio
                    {
                        Id = Convert.ToInt32(dr["idBeneficio"]),
                        Nombre = dr["Nombre"].ToString(),
                        Porcentaje = Convert.ToDouble(dr["Porcentaje"]),
                        Aplicacion = dr["Aplicabilidad"].ToString()
                    };
                }

                return objBeneficio;
            }
            catch (SqlException ex)
            {

                throw new CustomExceptions.DataAccessException("Ha ocurrido un error al buscar un beneficio por nombre", ex);

            }
            catch (Exception e)
            {

                throw e;
            }
       }
        /// <summary>
        /// Este método sirve para validar si en la listas globales hay información, dependiendo de la lista, aquí se llama al método para insertar, modificar o eliminar.
        /// </summary>
        /// <author>Mathias Muller</author>

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Beneficio objBeneficio in _insertItems)
                        {
                            InsertBeneficio(objBeneficio);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Beneficio objBeneficio in _updateItems)
                        {
                            UpdateBeneficio(objBeneficio);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Beneficio objBeneficio in _deleteItems)
                        {
                            DeleteBeneficio(objBeneficio);
                        }
                    }

                    scope.Complete();
                }
                catch (TransactionAbortedException ex)
                {
                    throw ex;

                }
                catch (ApplicationException ex)
                {
                    throw ex;

                }
                finally
                {
                    Clear();
                }

            }
        }
        /// <summary>
        /// Limpia la información en las listas globales.
        /// </summary>
        /// <author>Mathias Muller</author>
        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        /// <summary>
        /// Inserta un beneficio en la base de datos.
        /// </summary>
        /// <author>Mathias Muller</author>

        private void InsertBeneficio(Beneficio objBeneficio)
        {
            

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Nombre", objBeneficio.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Porcentaje", objBeneficio.Porcentaje));
                cmd.Parameters.Add(new SqlParameter("@Aplicabilidad", objBeneficio.Aplicacion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_crearBeneficio");

                actividad = "Se ha registrado un Beneficio";
                registrarAccion(actividad);


            }
            catch (SqlException ex)
            {

                throw new CustomExceptions.DataAccessException("Ha ocurrido un error al crear un beneficio", ex);

            }

            catch (Exception ex)
            {

                throw ex;

            }

        }


        /// <summary>
        /// Modifica un beneficio en la base de datos.
        /// </summary>
        /// <author>Mathias Muller</author>

        private void UpdateBeneficio(Beneficio objBeneficio)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Id", objBeneficio.Id));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objBeneficio.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Porcentaje", objBeneficio.Porcentaje));
                cmd.Parameters.Add(new SqlParameter("@Aplicabilidad", objBeneficio.Aplicacion));


                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_modificarBeneficio");

                actividad = "Se ha modificado un Beneficio";
                registrarAccion(actividad);

            }
            catch (SqlException ex)
            {

                throw new CustomExceptions.DataAccessException("Ha ocurrido un error al editar un beneficio", ex);

            }

            catch (Exception ex){

                throw ex;
            }
        }

        /// <summary>
        /// Elimina un beneficio de la base de datos.
        /// </summary>
        /// <author>Mathias Muller</author>

        private void DeleteBeneficio(Beneficio objBeneficio)
        {
 
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@Nombre", objBeneficio.Nombre));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_eliminarBeneficio");

                actividad = "Se ha Eliminado un Beneficio";
                registrarAccion(actividad);
            }

            catch (SqlException ex)
            {

                throw new CustomExceptions.DataAccessException("Ha ocurrido un error al eliminar un beneficio", ex);

            }

            catch (Exception e)
            {
                throw e;
            }
        }

        public void registrarAccion(string pactividad)
        {

            RegistroAccion objRegistro;
            DateTime fecha = DateTime.Today;
            string nombreUsuario = Globals.userName;
            string nombreRol = Globals.userRol.Nombre;
            string descripcion = pactividad;


            objRegistro = new RegistroAccion(nombreUsuario, nombreRol, descripcion, fecha);

            try
            {

                RegistroAccionRepository objRegistroRep = new RegistroAccionRepository();
                objRegistroRep.InsertAccion(objRegistro);
            }
            catch (SqlException ex)
            {

                throw new CustomExceptions.DataAccessException("Ha ocurrido un error al registrar una accion", ex);

            }
            catch (Exception e)
            {

                throw e;
            }

        }

    }
}

