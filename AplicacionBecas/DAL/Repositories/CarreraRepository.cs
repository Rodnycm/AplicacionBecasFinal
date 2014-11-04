using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;
using DAL.Repositories;

namespace DAL
{

    public class CarreraRepository : IRepository<Carrera>
    {
        public string actividad;
        private static CarreraRepository instance;
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        private CarreraRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        ///<summary>Patron singleton, encargado de obtener una unica instancia de esta clase</summary>
        //<autor>Alvaro Artavia</autor>
        public static CarreraRepository Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new CarreraRepository() { };
                }
                return instance;
            }
        }

        ///<summary>Agrega a la lista los objetos que se deseam eliminar,modificar o insertar</summary>
        ///<param name="entity">Objeto a ingresar a la lista</param>
        //<autor>Alvaro Artavia</autor>

        public void Insert(Carrera entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Carrera entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(Carrera entity)
        {
            _updateItems.Add(entity);
        }

        ///<summary>Obtiene de la base de datos todos los elementos en la tabla carreras</summary>
        ///<returns>Retorna una coleccion de objetos de tipo carrera<retruns>
        //<autor>Alvaro Artavia</autor>

        public IEnumerable<Carrera> GetAll()
        {

            List<Carrera> pCarrera = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_consultarCarreras");

            if (ds.Tables[0].Rows.Count > 0)
            {

                pCarrera = new List<Carrera>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    pCarrera.Add(new Carrera
                    {

                        nombre = dr["Nombre"].ToString(),
                        codigo = dr["Código"].ToString(),
                        color = dr["Color"].ToString(),
                        Id = Convert.ToInt32(dr["id"])
                        //DirectorAcademico = dr["director"].ToString()
                    });
                }
            }

            return pCarrera;
        }

        public Carrera GetByNombre(String parametro)
        {
            Carrera objCarrera = null;

            return objCarrera;
        }

        public Carrera GetById(int id)
        {

            Carrera objCarrera = null;
            var sqlQuery = "";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@idProducto", id);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {

                var dr = ds.Tables[0].Rows[0];
                objCarrera = new Carrera
                {

                    nombre = dr["nombre"].ToString(),
                    codigo = dr["tipo"].ToString(),
                    color = dr["color"].ToString(),
                    directorAcademico = dr["director"].ToString()
                };
            }

            return objCarrera;
        }

        ///<summary>Metodo encargado de llamar a los metodos eliminar,insertar o modificar dependiendo 
        ///de la cantidad de objetos encontrados en la coleccion</summary>
        //<autor>Alvaro Artavia</autor>

        public void Save()
        {

            using (TransactionScope scope = new TransactionScope())
            {

                try
                {

                    if (_insertItems.Count > 0)
                    {

                        foreach (Carrera objCarrera in _insertItems)
                        {
                            InsertCarrera(objCarrera);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Carrera p in _updateItems)
                        {
                            UpdateCarrera(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Carrera p in _deleteItems)
                        {
                            DeleteCarrera(p);
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

        ///<summary>Vacia las colecciones</summary>
        //<autor>Alvaro Artavia</autor>

        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        ///<summary>Inserta en la base de datos un objeto carrera</summary>
        ///<param name="objCarrera">Objeto de tipo carrera</param>
        //<autor>Alvaro Artavia</autor>

        private void InsertCarrera(Carrera objCarrera)
        {

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@Nombre", objCarrera.nombre));
                cmd.Parameters.Add(new SqlParameter("@Código", objCarrera.codigo));
                cmd.Parameters.Add(new SqlParameter("@Color", objCarrera.color));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_agregarCarrera");

                actividad = "Se ha Registrado una Carrera";
                registrarAccion(actividad);
            }
            catch (Exception ex)
            {

            }
        }

        ///<summary>Modifica en la base de datos un objeto carrera</summary>
        ///<param name="objCarrera">Objeto de tipo carrera</param>
        //<autor>Alvaro Artavia</autor>

        private void UpdateCarrera(Carrera objCarrera)
        {

            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Nombre", objCarrera.nombre));
                cmd.Parameters.Add(new SqlParameter("@Codigo", objCarrera.codigo));
                cmd.Parameters.Add(new SqlParameter("@Color", objCarrera.color));
                cmd.Parameters.Add(new SqlParameter("@idCarrera", objCarrera.Id));
                //cmd.Parameters.Add(new SqlParameter("@directorAcademico", objCarrera.DirectorAcademico));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_modificarCarrera");

                actividad = "Se ha Editado una Carrera";
                registrarAccion(actividad);

            }
            catch (Exception ex)
            {

            }
        }
        ///<summary>Elimina en la base de datos un objeto carrera</summary>
        ///<param name="objCarrera">Objeto de tipo carrera</param>
        //<autor>Alvaro Artavia</autor>

        private void DeleteCarrera(Carrera objCarrera)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@Codigo", objCarrera.codigo));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_eliminarCarrera");

                actividad = "Se ha Eliminado una Carrera";
                registrarAccion(actividad);

            }
            catch (SqlException ex)
            {
                //logear la excepcion a la bd con un Exception
                //throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);
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
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
