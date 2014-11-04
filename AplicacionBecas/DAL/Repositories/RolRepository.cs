using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;


namespace DAL.Repositories
{
    public class RolRepository : IRepository<Rol>
    {
        private string actividad;
        private static RolRepository instance;
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;


        public RolRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        /// <summary>
        /// trae la instancia de Rol repository
        /// </summary>
        public static RolRepository Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new RolRepository() { };
                }
                return instance;
            }
        }
        /// <summary>
        /// agrega a una lista los roles a insertar
        /// </summary>
        /// <param name="entity">el rol a eliminar</param>
        public void Insert(Rol entity)
        {
            _insertItems.Add(entity);
        }

        /// <summary>
        /// agrega a una lista los roles a eliminar
        /// </summary>
        /// <param name="entity">el rol a eliminar</param>
        public void Delete(Rol entity)
        {
            _deleteItems.Add(entity);
        }

        /// <summary>
        /// agrega a una lista los roles a modificar
        /// </summary>
        /// <param name="entity">rol a modificar</param>
        public void Update(Rol entity)
        {
            _updateItems.Add(entity);
        }

        /// <summary>
        /// trae todos losroles a consultar
        /// </summary>
        /// <returns>una lista de roles</returns>
        public IEnumerable<Rol> GetAll()
        {


            List<Rol> pRol = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_listarRol");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pRol = new List<Rol>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pRol.Add(new Rol
                    {
                        Id = Convert.ToInt32(dr["IdRol"]),
                        Nombre = dr["Nombre"].ToString()
                    });
                }
            }

            return pRol;
        }

        public Rol GetById(int id)
        {
            Rol objRol = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@id", id);

            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarRolPorId");

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objRol = new Rol
                {
                    Id = Convert.ToInt32(dr["IdRol"]),
                    Nombre = dr["Nombre"].ToString(),
                };
            }


            return objRol;
        }
        /// <summary>
        /// consulta por nombre el rol
        /// </summary>
        /// <param name="pnombre">el rol a consultar</param>
        /// <returns>el rol consultado</returns>
        /// 

        public Rol GetByNombre(String pnombre)
        {

            Rol objRol = null;
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@Nombre", pnombre));

                var ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarRol");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    var dr = ds.Tables[0].Rows[0];

                    objRol = new Rol
                    {
                        Id = Convert.ToInt32(dr["IdRol"]),
                        Nombre = dr["Nombre"].ToString()
                    };
                }

            }

            catch (Exception ex)
            {
                throw ex;
          
            }


            return objRol;
        }

        /// <summary>
        /// Guarda los cambios
        /// </summary>
        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Rol objRol in _insertItems)
                        {
                            InsertRol(objRol);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Rol p in _updateItems)
                        {
                            UpdateRol(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Rol p in _deleteItems)
                        {
                            DeleteRol(p);
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
        /// Limpia los datos
        /// </summary>
        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }


        /// <summary>
        /// Inserta el rol a la BD
        /// </summary>
        /// <param name="objRol">el rol a insertar</param>
        private void InsertRol(Rol objRol)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Nombre", objRol.Nombre));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_agregarRol");


                actividad = "Se ha registrado un Rol";
                registrarAccion(actividad);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        /// <summary>
        /// Modifica el rol a la BD
        /// </summary>
        /// <param name="objRol">el rol a modificar</param>
        private void UpdateRol(Rol objRol)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@IdRol", objRol.Id));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objRol.Nombre));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_modificarRol");


                actividad = "Se ha Editado un Rol";
                registrarAccion(actividad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Elimina el rol dela BD
        /// </summary>
        /// <param name="objRol">El rol a eliminar</param>
        private void DeleteRol(Rol objRol)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@IdRol", objRol.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_eliminarRol");


                actividad = "Se ha Eliminado un Rol";
                registrarAccion(actividad);

            }
            catch (SqlException ex)
            {
                throw ex;
                //logear la excepcion a la bd con un Exception
                //throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);

            }
            catch (Exception ex)
            {
                throw ex;
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
