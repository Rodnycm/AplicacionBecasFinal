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
    public class CursoRepository : IRepository<Curso>
    {

        private static CursoRepository instance;
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;



        private CursoRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }



        public static CursoRepository Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new CursoRepository() { };
                }
                return instance;
            }
        }



        public void Insert(Curso entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Curso entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(Curso entity)
        {
            _updateItems.Add(entity);
        }



        public IEnumerable<Curso> GetAll()
        {

            List<Curso> pCurso = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_listar_huesos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pCurso = new List<Curso>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pCurso.Add(new Curso
                    {

                        nombre = dr["nombre"].ToString(),
                        codigo = dr["tipo"].ToString(),
                        cuatrimestre = dr["cuatrimestre"].ToString(),
                        creditos = Convert.ToInt32(dr["creditos"]),
                        precio = Convert.ToDouble(dr["creditos"])
                    });
                }
            }

            return pCurso;
        }



        public Curso GetByNombre(String parametro)
        {
            Curso objCurso = null;

            return objCurso;
        }

        public Curso GetById(int id)
        {

            Curso objCurso = null;
            var sqlQuery = "SELECT Id, Nombre, Precio FROM Producto WHERE id = @idProducto";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@idProducto", id);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {

                var dr = ds.Tables[0].Rows[0];
                objCurso = new Curso
                {

                    nombre = dr["nombre"].ToString(),
                    codigo = dr["tipo"].ToString(),
                    cuatrimestre = dr["cuatrimestre"].ToString(),
                    creditos = Convert.ToInt32(dr["creditos"]),
                    precio = Convert.ToDouble(dr["creditos"])
                };
            }

            return objCurso;
        }



        public void Save()
        {

            using (TransactionScope scope = new TransactionScope())
            {

                try
                {

                    if (_insertItems.Count > 0)
                    {

                        foreach (Curso objCurso in _insertItems)
                        {
                            InsertCurso(objCurso);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Curso p in _updateItems)
                        {
                            UpdateCurso(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Curso p in _deleteItems)
                        {
                            DeleteCurso(p);
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


        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }


        private void InsertCurso(Curso objCurso)
        {

            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Nombre", objCurso.nombre));
                cmd.Parameters.Add(new SqlParameter("@Código", objCurso.codigo));
                cmd.Parameters.Add(new SqlParameter("@Cuatrimestre", objCurso.cuatrimestre));
                cmd.Parameters.Add(new SqlParameter("@Creditos", objCurso.cuatrimestre));
                cmd.Parameters.Add(new SqlParameter("@Precio", objCurso.precio));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_crearCurso ");

            }
            catch (Exception ex)
            {

            }
        }


        private void UpdateCurso(Curso objCurso)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Nombre", objCurso.nombre));
                cmd.Parameters.Add(new SqlParameter("@Código", objCurso.codigo));
                cmd.Parameters.Add(new SqlParameter("@Cuatrimestre", objCurso.cuatrimestre));
                cmd.Parameters.Add(new SqlParameter("@Creditos", objCurso.cuatrimestre));
                cmd.Parameters.Add(new SqlParameter("@Precio", objCurso.precio));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_modificar_hueso");

            }
            catch (Exception ex)
            {

            }
        }


        private void DeleteCurso(Curso objCurso)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@", objCurso.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_borrar_hueso");

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
