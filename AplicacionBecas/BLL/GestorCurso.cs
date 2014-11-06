using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using DAL;


namespace BLL{

    public class GestorCurso
    {



        //<summary> Método que se encarga de crear un nuevo Curso</summary>
        //<author> Valeria Ramírez Cordero</author> 
        //<param name = "nombre"> variable de tipo String que almacena nombre del curso</param>
        //<param name= "codigo" > variable de tipo String que almacena el código del curso </param>
        //<param name = "cuatrimestre"> variable de tipo String que almacena el cuatrimestre en el que se encuentra el curso  </param>
        //<param name = " creditos"> variable de tipo int que almacena los créditos del curso</param>
        //<param name = "precio"> variable de tipo String que almacena el precio del curso</param>
        //<returns> No retorna valor.</returns> 


        public void agregarCurso(string pnombre, string pcodigo, string pcuatrimestre, string pcreditos, string pprecio)
        {

            try
            {
                int creditos = Convert.ToInt32(pcreditos);
                double precio = Convert.ToDouble(pprecio);
                Curso objCurso = ContenedorMantenimiento.Instance.crearObjetoCurso(pnombre, pcodigo, pcuatrimestre, creditos, precio);
                if (objCurso.IsValid)
                {
                    CursoRepository.Instance.Insert(objCurso);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objCurso.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage + "\n");
                    }
                    throw new ApplicationException(sb.ToString());
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        //<summary> Método que se encarga de buscar todos los cursos que existen en el sistema</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param > No recibe parámetros  </param>
        //<returns> Retorna una lista con los cursos registrados</returns> 
        public IEnumerable<Curso> consultarCursos()
        {
            return CursoRepository.Instance.GetAll();
        }



        //<summary> Método que se encarga de buscar un curso en específico</summary>
        //<author>Valeria Ramírez Cordero</author> 
        //<param name = "parametro">variable de tipo String que almacena el nombre o el código del curso </param>
        //<returns> Retorna el curso buscado</returns> 
        public Curso BuscarCurso(String pparametro)
        {
            return CursoRepository.Instance.GetByNombre(pparametro);

        }


        //public void eliminarProducto(int idHueso){

        //    Hueso objHueso = new Hueso { Id = idHueso };
        //    UoW.HuesoRepository.Delete(objHueso);
        //}





        //<summary> Método que se encarga de modificar un Curso</summary>
        //<author> Valeria Ramírez Cordero</author> 
        //<param name = "nombre"> variable de tipo String que almacena nombre del curso</param>
        //<param name= "codigo" > variable de tipo String que almacena el código del curso </param>
        //<param name = "cuatrimestre"> variable de tipo String que almacena el cuatrimestre en el que se encuentra el curso  </param>
        //<param name = " creditos"> variable de tipo int que almacena los créditos del curso</param>
        //<param name = "precio"> variable de tipo String que almacena el precio del curso</param>
        //<returns> No retorna valor.</returns> 

        public void modificarCurso(String pcodigo, String pnombre, String pcuatrimestre, int pcreditos, double pprecio, int pidCurso)
        {

            try
            {
                int creditos = Convert.ToInt32(pcreditos);
                double precio = Convert.ToDouble(pprecio);
                Curso objetoCurso = ContenedorMantenimiento.Instance.crearObjetoCurso(pnombre, pcodigo, pcuatrimestre, pcreditos, pprecio, pidCurso);
                CursoRepository.Instance.Update(objetoCurso);

                 if (objetoCurso.IsValid)
                {
                    CursoRepository.Instance.Update(objetoCurso);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objetoCurso.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage + "\n");
                    }
                    throw new ApplicationException(sb.ToString());
                }
            
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public void eliminarCurso(String pcodigo)
        {
            Curso objCurso = ContenedorMantenimiento.Instance.crearObjetoCurso(pcodigo);
            CursoRepository.Instance.Delete(objCurso);

        }

        public void guardarCambios()
        {

            CursoRepository.Instance.Save();
            //try
            //{

            //    }
            //    catch (DataAccessException ex)
            //    {
            //        throw ex;
            //    }
            //    catch (Exception ex)
            //    {
            //        //logear a la bd
            //        throw new BusinessLogicException("Ha ocurrido un error al eliminar un usuario", ex);
            //    }
        }

        public IEnumerable<Curso> getCursoPorCuatrimestre(String pcuatri) {

            try{

            return CursoRepository.Instance.getCursoPorCuatrimestre(pcuatri);

            }
            catch (Exception ex){

                throw ex;

            }
        }

        public Array consultarCursosPorCuatrimestre()
        {

            try
            {

                return CursoRepository.Instance.consultarCursosPorCuatrimestre();

            }
            catch (Exception ex)
            {

                throw ex;

            }
        }
    }

  
}
