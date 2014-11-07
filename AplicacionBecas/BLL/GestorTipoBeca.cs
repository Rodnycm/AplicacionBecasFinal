using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DAL;
using DAL.Repositories;

namespace BLL
{
    public class GestorTipoBeca
    {
        ///<sumary>
        ///El metodo agregarTipoBeca recibe los parámetros necesarios para poder crear la instancia tipo beca
        ///Este envía los parámetros para poder crear un tipo de beca y recibe una instancia
        ///Envía el objeto nuevo al repositorio para agregarlo a la lista del repositorio respectiva.
        ///El objeto es enviado para ser agregado en la base de datos
        ///En caso de algún error se atrapa la excepción
        ///</sumary>
        ///<author>María Jesús Gutiérrez</author>
        ///<param name="descripcion">Esta es la descripción del tipo de beca</param>
        ///<param name="estado">Este es el estado en el que se encuentra el tipo de beca</param>
        ///<param name="nombre"> Este es el nombre del tipo de beca</param>

        public TipoBeca agregarTipoBeca(string nombre, string estado, string descripcion)
        {
            TipoBeca objTipoBeca = new TipoBeca(nombre, estado, descripcion);


            try
            {
                if (objTipoBeca.IsValid)
                {
                    TipoBecaRepository.Instance.Insert(objTipoBeca);
                    return objTipoBeca;

                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objTipoBeca.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new ApplicationException(sb.ToString());
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Se llama al método GetAll del repositorio y este recibe una lista con los tipos de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <returns>Retorna una lista de los tipos de beca</returns>
        public IEnumerable<TipoBeca> consultarTipoBeca()
        {
            return TipoBecaRepository.Instance.GetAll();
        }

        public TipoBeca buscarUnTipoBeca(string pnombre)
        {
            return TipoBecaRepository.Instance.GetByNombre(pnombre);
        }
        /// <summary>
        /// Llama al método Save del repository
        ///</summary>
        ///<author>María Jesús Gutiérrez</author>
        public void guardarCambios()
        {

            TipoBecaRepository.Instance.Save();
        }
        public void asignarBeneficioTipoBeca(List<Beneficio> listaBeneficios, TipoBeca objTipoBeca)
        {
            BeneficioRepository.objTipoBeca = objTipoBeca;
            foreach (Beneficio objBeneficio in listaBeneficios)
            {

                BeneficioRepository.Instance.Insert(objBeneficio);

            }
            BeneficioRepository.Instance.asignarBeneficio();

        }

        public void asignarRequisitoTipoBeca(List<Requisito> listaRequisitos, TipoBeca objTipoBeca)
        {
            RequisitoRepository.objTipoBeca = objTipoBeca;
            foreach (Requisito objRequisito in listaRequisitos)
            {
                RequisitoRepository.Instance.Insert(objRequisito);
            }
            RequisitoRepository.Instance.asignarRequisito();
        }

        public void modificarTipoBeca(string pnombre, string pestado, string pdescripcion)
        {
            TipoBeca objTipoBeca = ContenedorMantenimiento.Instance.crearTipoBeca(pnombre, pestado, pdescripcion);
            try
            {
                if (objTipoBeca.IsValid)
                {
                    TipoBecaRepository.Instance.Update(objTipoBeca);

                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objTipoBeca.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new ApplicationException(sb.ToString());
                }


            }
            catch (Exception)
            {

                throw;
            }

        }

        public void eliminarTipoBeca(String pnombre)
        {
            try
            {
                TipoBeca objTipoBeca = ContenedorMantenimiento.Instance.crearTipoBeca(pnombre);
                TipoBecaRepository.Instance.Delete(objTipoBeca);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}



