using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class BeneficioRepository : IRepository<Beneficio>
    {
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

                }
                catch (ApplicationException ex)
                {

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

            }
            catch (Exception ex)
            {

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

            }
            catch (Exception ex)
            {
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

            }
            catch (SqlException ex)
            {
                //logear la excepcion a la bd con un Exception
                //throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);

            }
            catch (Exception ex)
            {
                //logear la excepcion a la bd con un Exception
                //throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);
            }
        }

    }
}

