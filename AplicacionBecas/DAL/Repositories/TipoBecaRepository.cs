using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using DAL.Repositories;
using System.Transactions;

namespace DAL.Repositories
{
    public class TipoBecaRepository : IRepository<TipoBeca>
    {
        private static TipoBecaRepository instance;
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        /// <summary>
        /// Constructor del repositorio
        /// Contiene las instancias de las listas delos tipos de beca de insertar, eliminar y modificar.
        /// </summary>
        ///<author>María Jesús Gutiérrez</author>
        public TipoBecaRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        /// <summary>
        /// Encargado de agregar un tipo de beca a la lista de insertar.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="entity"></param>
        public void Insert(TipoBeca entity)
        {
            _insertItems.Add(entity);
        }

        /// <summary>
        ///Encargado de agregar un tipo de beca a la lista de eliminar.
        /// </summary>
        ///<author>María Jesús Gutiérrez</author>
        /// <param name="entity"></param>
        public void Delete(TipoBeca entity)
        {
            _deleteItems.Add(entity);
        }

        /// <summary>
        /// Encargado de modificar un tipo de beca a la lista de modificar.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="entity"></param>
        public void Update(TipoBeca entity)
        {
            _updateItems.Add(entity);
        }

        /// <summary>
        /// Método que valida las instancias del TipoBecaRepository
        /// Crea una instancia cuando esta no se haya encontrado, de lo contrario utiliza la ya creada.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        public static TipoBecaRepository Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new TipoBecaRepository() { };
                }
                return instance;
            }
        }

        /// <summary>
        /// Encargado de traer el data set de la base de datos.
        /// Contiene DataRow que por cada uno que tenga, este instancia un tipo de beca.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <returns>Retorna una lista de tipo de beca</returns>
        public IEnumerable<TipoBeca> GetAll()
        {
            List<TipoBeca> ptipoBeca = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_consultarTipoBecas");
            if (ds.Tables[0].Rows.Count > 0)
            {
                ptipoBeca = new List<TipoBeca>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ptipoBeca.Add(new TipoBeca
                    {
                        Id = Convert.ToInt32(dr["idTipoBeca"]),
                        nombre = dr["nombre"].ToString(),
                        objD = Convert.ToDateTime(dr["fechaCreacion"]),
                        estado = dr["estado"].ToString(),
                        descripcion = dr["descripcion"].ToString()
                    });
                }
            }

            return ptipoBeca;
        }

        /// <summary>
        /// Método que tiene un data set de la base de datos.
        /// Instancia un tipo de beca de acuerdo a la información enviada a la base de datos.
        /// El tipo de beca es buscado por el nombre
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="id"></param>
        /// <returns>Retorna un objeto de tipo beca</returns>
        public TipoBeca GetByNombre(string nombre)
        {
            TipoBeca objTipoBeca = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@nombre", nombre);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objTipoBeca = new TipoBeca
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    nombre = dr["nombre"].ToString(),
                    objD = Convert.ToDateTime(dr["fechaCreacion"]),
                    estado = dr["estado"].ToString(),
                    descripcion = dr["descripcion"].ToString()
                };
            }



            return objTipoBeca;
        }

        /// <summary>
        /// Método que contiene un data set de la base de datos.
        /// Instancia un tipo de beca de acuerdo a la información enviada.
        /// El tipo de beca es buscado por el id
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="id"></param>
        /// <returns>Retorna un objeto de tipo beca</returns>
        public TipoBeca GetById(int id)
        {
            TipoBeca objTipoBeca = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idProducto", id);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objTipoBeca = new TipoBeca
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    nombre = dr["nombre"].ToString(),
                    estado = dr["estado"].ToString(),
                    descripcion = dr["descripcion"].ToString()
                };
            }



            return objTipoBeca;
        }
        /// <summary>
        /// Método encargado de validar cada una de las listas de insertar, modificar y eliminar.
        /// Este válida si hay o no información en cada lista.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (TipoBeca objTipoBeca in _insertItems)
                        {
                            InsertTipoBeca(objTipoBeca);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (TipoBeca p in _updateItems)
                        {


                            throw new Exception("Changed UpdateTipoBeca to commented code");
                            //UpdateTipoBeca(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (TipoBeca p in _deleteItems)
                        {



                            throw new Exception("Changed DeleteTipoBecas to commented code");
                            //DeleteTipoBeca(p);
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
        /// Método que limpia la información en las listas globales.
        /// </summary>
        /// <author>Maria Jesús Gutiérrez</author>
        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        /// <summary>
        /// Método que inserta un tipo de beca en la base de datos
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="objTipoBeca"></param>
        private void InsertTipoBeca(TipoBeca objTipoBeca)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@nombre", objTipoBeca.nombre));
                cmd.Parameters.Add(new SqlParameter("@fechaCreación", objTipoBeca.objD));
                cmd.Parameters.Add(new SqlParameter("@estado", objTipoBeca.estado));
                cmd.Parameters.Add(new SqlParameter("@descripcion", objTipoBeca.descripcion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_agregarTipoBeca");

            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Método que modifica un tipo de beca en la base de datos.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="objTipoBeca"></param>
        private void UpdateTipoBeca(TipoBeca objTipoBeca)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@nombre", objTipoBeca.nombre));
                cmd.Parameters.Add(new SqlParameter("@estado", objTipoBeca.estado));
                cmd.Parameters.Add(new SqlParameter("@descripcion", objTipoBeca.descripcion));


                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_modificarTipoBeca");

            }
            catch (Exception ex)
            {
                //throw new DataAccessException("No se pudó modificar el tipo de la beca", ex);
            }
        }

        /// <summary>
        /// Método que elimina un tipo de beca en la base de datos
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="objTipoBeca"></param>
        private void DeleteTipoBeca(TipoBeca objTipoBeca)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@", objTipoBeca.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_eliminarTipoBeca");

            }
            catch (SqlException ex)
            {
                //logear la excepcion a la bd con un Exception
                //throw new DataAccessException("Ha ocurrido un error al eliminar el tipo de beca", ex);

            }
            catch (Exception ex)
            {
                //logear la excepcion a la bd con un Exception
                //throw new DataAccessException("Ha ocurrido un error al eliminar un tipo de beca", ex);
            }
        }
    }
}




