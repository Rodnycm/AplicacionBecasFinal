using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using System.Transactions;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Repositories
{
    public class RequisitoRepository : IRepository<Requisito>
    {
        public string actividad;
        private static RequisitoRepository instance;
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public RequisitoRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }


        //<summary> Método que se encarga de instanciar un RequisitoRepository</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param> No recibe valor  </param>
        //<returns> Retorna una instancia de la clase RequisitoRepository.</returns> 
        public static RequisitoRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RequisitoRepository() { };
                }
                return instance;
            }
        }

        //<summary> Método que se encarga de agregar un requisito a la lista de requisitos que se desean insertar</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "entity">  variable de tipo Requisito que contiene el objeto requisito que se desea insertar  </param>
        //<returns> No retorna valor.</returns> 
        public void Insert(Requisito entity)
        {
            _insertItems.Add(entity);
        }

        //<summary> Método que se encarga de agregar un requisito a la lista de requisitos que se desean eliminar</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "entity"> variable de tipo Requisito que contiene el objeto requisito que se desea eliminar  </param>
        //<returns> No retorna valor.</returns> 
        public void Delete(Requisito entity)
        {
            _deleteItems.Add(entity);
        }

        //<summary> Método que se encarga de agregar un requisito a la lista de requisitos que se desean modificar</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "entity">variable de tipo Requisito que contiene el objeto requisito que se desea modificar  </param>
        //<returns> No retorna valor.</returns> 
        public void Update(Requisito entity)
        {
            _updateItems.Add(entity);
        }



        //<summary> Método que se encarga de traer de la base de datos todos los requisitos registrados </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param> no recibe parametros </param>
        //<returns>Retorna una lista con todos los requisitos registrados en el sistema.</returns> 
        public IEnumerable<Requisito> GetAll()
        {
            List<Requisito> prequisito = null;
            /*var sqlQuery = "SELECT Id, Nombre, Precio FROM Producto";
            SqlCommand cmd = new SqlCommand(sqlQuery);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                pmusculo = new List<Musculo>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pmusculo.Add(new Musculo
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        nombre = dr["nombre"].ToString(),
                       ubicacion = dr["ubicacion"].ToString(),
                        origen = dr["Origen"].ToString(),
                        insercion = dr["insercion"].ToString()
                    });
                }
            }*/

            return prequisito;
        }

        //<summary> Método que se encarga de traer de la base de datos un requisito específico </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "id"> parámetro de tipo int que contiene el Id del requisito que se desea traer </param>
        //<returns>Retorna el requisito deseado</returns> 
        public Requisito GetById(int id)
        {
            Requisito objRequisito = null;
            /*var sqlQuery = "SELECT Id, Nombre, Precio FROM Producto WHERE id = @idProducto";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@idProducto", id);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objMusculo = new Musculo
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    nombre = dr["nombre"].ToString(),
                    ubicacion = dr["ubicacion"].ToString(),
                    origen = dr["Origen"].ToString(),
                    insercion = dr["insercion"].ToString()
                };
            }*/

            return objRequisito;
        }

        public Requisito GetByNombre(String pnombre)
        {
            Requisito objRequisito = null;
            /*var sqlQuery = "SELECT Id, Nombre, Precio FROM Producto WHERE id = @idProducto";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@idProducto", id);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objMusculo = new Musculo
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    nombre = dr["nombre"].ToString(),
                    ubicacion = dr["ubicacion"].ToString(),
                    origen = dr["Origen"].ToString(),
                    insercion = dr["insercion"].ToString()
                };
            }*/

            return objRequisito;
        }


        //<summary> Método que se encarga de guardar en la base de datos los cambios realizados </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param> No recibe parámetros </param>
        //<returns>No retorna valor</returns> 
        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {

                        foreach (Requisito objRequisito in _insertItems)
                        {
                            InsertRequisito(objRequisito);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Requisito p in _updateItems)
                        {
                            UpdateRequisito(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Requisito p in _deleteItems)
                        {
                            DeleteRequisito(p);
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


        //<summary> Método que se encarga limpiar todas las listas </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param> No recibe parámetros </param>
        //<returns>No retorna valor </returns> 
        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        //<summary> Método que se encarga de insertar en la base de datos un requisito </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "objRequisto"> variable de tipo Requisito que contiene el objeto requisito que se desea insertar en la base de datos </param>
        //<returns> No retorna valor</returns> 
        private void InsertRequisito(Requisito objRequisito)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@nombre", objRequisito.nombre));
                cmd.Parameters.Add(new SqlParameter("@descripcion", objRequisito.descripcion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_crearRequisito");

                actividad = "Se ha Registrado un Requisito";
                registrarAccion(actividad);

            }
            catch (Exception ex)
            {

            }
        }

        //<summary> Método que se encarga de modificar en la base de datos un requisito </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "objRequisto"> variable de tipo Requisito que contiene el objeto requisito que se desea modificar en la base de datos </param>
        //<returns> No retorna valor</returns> 
        private void UpdateRequisito(Requisito objRequisito)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@nombre", objRequisito.nombre));
                cmd.Parameters.Add(new SqlParameter("@ubicacion", objRequisito.descripcion));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "");

                actividad = "Se ha Editado un Requisito";
                registrarAccion(actividad);

            }
            catch (Exception ex)
            {

            }
        }

        //<summary> Método que se encarga de eliminar un requisito de la base de datos </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "objRequisto"> variable de tipo Requisito que contiene el objeto requisito que se desea eliminar de la base de datos </param>
        //<returns> No retorna valor</returns> 
        private void DeleteRequisito(Requisito objRequisito)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@", objRequisito.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "");

                actividad = "Se ha Eliminado un Requisito";
                registrarAccion(actividad);

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
