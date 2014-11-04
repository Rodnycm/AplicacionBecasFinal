using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using DAL;


namespace BLL
{
    public class GestorCurso{

        //public void agregarCurso(string nombre, string codigo, string cuatrimestre, int creditos, double precio)
        //{
        //    try
        //    {
        //        Curso objCurso = new Curso(nombre, codigo, cuatrimestre, creditos, precio);
        //        //if (objCurso.IsValid)
        //        //{
        //        CursoRepository.Instance.Insert(objCurso);
        //        //}
        //        //else
        //        //{
        //        //    StringBuilder sb = new StringBuilder();
        //        //    foreach (RuleViolation rv in objCurso.GetRuleViolations())
        //        //    {
        //        //        sb.AppendLine(rv.ErrorMessage);
        //        //    }
        //        //    throw new ApplicationException(sb.ToString());
        //        //}
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}




        //public IEnumerable<Curso> buscarCurso()
        //{
        //    return CursoRepository.Instance.GetAll();
        //}




        ////public void BuscarCurso(int Id){
        ////    CursoRepository.Instance.GetById(Id);
        ////}

        ////public void eliminarProducto(int idHueso){

        ////    Hueso objHueso = new Hueso { Id = idHueso };
        ////    UoW.HuesoRepository.Delete(objHueso);
        ////}






        ////public void modificarHueso(int idHueso, string nombre, string tipo, string ubicacion)
        ////{

        ////    Hueso objHueso = new Producto(idHueso, nombre, tipo,ubicacion);
        ////    UoW.ProductoRepository.Update(objHueso);

        ////}

        ////public void eliminarProducto(int idHueso)
        ////{

        ////    Hueso objHueso = new Hueso { Id = idHueso };
        ////    UoW.HuesoRepository.Delete(objHueso);
        ////}

        ////public IEnumerable<Curso> consultarCurso()
        ////{
        ////    return CursoRepository.Instance.GetAll();
        ////}

        ////public Hueso consultarHuesoXID(int id)
        ////{
        ////    return UoW.HuesoRepository.GetById(id);
        ////}

        //public void guardarCambios()
        //{

        //    CursoRepository.Instance.Save();
        //    //try
        //    //{

        //    //    }
        //    //    catch (DataAccessException ex)
        //    //    {
        //    //        throw ex;
        //    //    }
        //    //    catch (Exception ex)
        //    //    {
        //    //        //logear a la bd
        //    //        throw new BusinessLogicException("Ha ocurrido un error al eliminar un usuario", ex);
        //    //    }
        //}


    }
}


