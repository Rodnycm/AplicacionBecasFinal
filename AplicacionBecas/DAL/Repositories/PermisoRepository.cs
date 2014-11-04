using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;
//using TIL.CustomExceptions;


namespace DAL
{
    public class PermisoRepository : IRepository<Permiso>
    {

        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;
        private static PermisoRepository instance;
        public PermisoRepository()
        {

            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        /// <summary>
        /// Devuelve la instancia del repository de ´permiso
        /// </summary>
        public static PermisoRepository Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new PermisoRepository() { };
                }
                return instance;
            }
        }

        /// <summary>
        /// agrega a una lista el permiso a insertar 
        /// </summary>
        /// <param name="entity">El permiso a insertar</param>
        public void Insert(Permiso entity)
        {
            _insertItems.Add(entity);
        }

        /// <summary>
        /// agrega a una lista el permiso a eliminar
        /// </summary>
        /// <param name="entity">Permiso a eliminar</param>
        public void Delete(Permiso entity)
        {
            _deleteItems.Add(entity);
        }

        /// <summary>
        /// agrega a una lista el permiso a modificar
        /// </summary>
        /// <param name="entity">Permiso a modificar</param>
        public void Update(Permiso entity)
        {
            _updateItems.Add(entity);
        }

        /// <summary>
        /// Trae todos los permisos de la BD
        /// </summary>
        /// <returns>Una lista de los permisos</returns>
        public IEnumerable<Permiso> GetAll()
        {


            List<Permiso> pPermiso = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_consultarPermisos");



            if (ds.Tables[0].Rows.Count > 0)
            {
                pPermiso = new List<Permiso>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pPermiso.Add(new Permiso
                    {
                        Id = Convert.ToInt32(dr["idPermiso"]),
                        Nombre = dr["Nombre"].ToString()
                    });
                }
            }

            return pPermiso;
        }

     
        public IEnumerable<Permiso> GetPermisosPorRol(int idRol)
        {
            List<Permiso> pPermiso = null;

           try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@IdRol", idRol));

                var ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_consultarPermisosPorRol");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    pPermiso = new List<Permiso>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        pPermiso.Add(new Permiso
                        {
                            Id = Convert.ToInt32(dr["idPermiso"]),
                            Nombre = dr["Nombre"].ToString(),
                            Descripción = dr["Descripcion"].ToString()
                        });
                    }
                }
            }

            catch (Exception ex)
           {
               throw ex;
            }


            return pPermiso;
        }

        public IEnumerable<Int32> GetIdRolesPermisos(int idPermiso,int idRol)
        {
            List<Int32> plistaIdRolesPermisos = null;

            //  try
            //  {
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@IdPermiso", idPermiso));
            cmd.Parameters.Add(new SqlParameter("@IdRol", idRol));

            var ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_consultarRolesPermisos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                plistaIdRolesPermisos = new List<Int32>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    plistaIdRolesPermisos.Add(Convert.ToInt32(dr["IdRolesPermisos"]));    
                }
            }
            //}

            //  catch (Exception ex)
            // {
            //      Console.Write(ex);
            //  }


            return plistaIdRolesPermisos;
        }
        /// <summary>
        /// Consulta el permiso por el nombre
        /// </summary>
        /// <param name="pnombre">permiso a consultar</param>
        /// <returns>El permiso consultado</returns>
        /// 


        public Permiso GetById(int id)
        {
            Permiso objPermiso = null;
            var sqlQuery = "";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@idPermiso", id);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objPermiso = new Permiso
                {
                    Nombre = dr["Nombre"].ToString()
                };
            }



            return objPermiso;
        }
        public Permiso GetByNombre(String pnombre)
        {
            Permiso objPermiso = null;
            var sqlQuery = "";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@nombre", pnombre);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objPermiso = new Permiso
                {
                    Nombre = dr["Nombre"].ToString()
                };
            }



            return objPermiso;
        }
        /// <summary>
        /// Guarda los permisos cambiados
        /// </summary>
        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Permiso objPermiso in _insertItems)
                        {
                            InsertPermiso(objPermiso);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Permiso p in _updateItems)
                        {
                            UpdatePermiso(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Permiso p in _deleteItems)
                        {
                            DeletePermiso(p);
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
        /// Limpia la lista 
        /// </summary>
        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        /// <summary>
        /// Inserta un permiso a la BD
        /// </summary>
        /// <param name="objPermiso">El permiso a insertar</param>
        private void InsertPermiso(Permiso objPermiso)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@nomb", objPermiso.Nombre));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_agregarPermiso");

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void InsertPermisoAUnRol(int IdPermiso, int pIdRol)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();


                cmd.Parameters.Add(new SqlParameter("@IdRol", pIdRol));
                cmd.Parameters.Add(new SqlParameter("@IdPermiso", IdPermiso));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_AsignarPermisosAUnRol");
                

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void EliminarPermisoAUnRol(Int32 idRolPermiso)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@IdRolPermiso", idRolPermiso));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_eliminarPermisoAUnRol");

            }
            catch (SqlException ex)
            {
                throw ex;
                //logear la excepcion a la bd con un Exception
                // throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);

            }
            catch (Exception ex)
            {
                throw ex;
                //logear la excepcion a la bd con un Exception
                // throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);
            }
        }
        /// <summary>
        /// Modifica un permiso a la BD
        /// </summary>
        /// <param name="objPermiso">El permiso a modificar</param>
        private void UpdatePermiso(Permiso objPermiso)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@nomb", objPermiso.Nombre));


                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_modificarPermiso");

            }
            catch (Exception ex)
            {
                throw ex;
               // throw new DataAccessException("No se pudó modificar el Permiso", ex);
            }
        }

        /// <summary>
        /// ELimina el permiso de la BD
        /// </summary>
        /// <param name="objPermiso">El permiso a eliminar</param>

        private void DeletePermiso(Permiso objPermiso)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@", objPermiso.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_borrarPermiso");

            }
            catch (SqlException ex)

            {
                throw ex;
                //logear la excepcion a la bd con un Exception
               // throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);

            }
            catch (Exception ex)
            {
                throw ex;
                //logear la excepcion a la bd con un Exception
               // throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);
            }
        }

    }
}
