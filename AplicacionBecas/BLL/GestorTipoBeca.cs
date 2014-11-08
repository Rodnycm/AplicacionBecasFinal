using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DAL;
using DAL.Repositories;
using TIL;

namespace BLL
{
    public class GestorTipoBeca
    {
        TipoBecaRepository objTipoBeca = new TipoBecaRepository();
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
            try {
                return TipoBecaRepository.Instance.GetAll();
            
            }
            catch (Exception ex) {

                throw ex ;
            }
            
        }

        public TipoBeca buscarUnTipoBeca(string pnombre)
        {

            try {
                return TipoBecaRepository.Instance.GetByNombre(pnombre);
            }
            catch(Exception ex){
                throw ex;
            }
            
        }
        public int idTipoBeca(string pnombre)
        {
            try
            {
                TipoBeca tmpTipo = buscarUnTipoBeca(pnombre);
                return tmpTipo.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        /// <summary>
        /// Llama al método Save del repository
        ///</summary>
        ///<author>María Jesús Gutiérrez</author>
        public void guardarCambios()
        {
            try
            {
                TipoBecaRepository.Instance.Save();
            }
            catch (CustomExceptions.DataAccessException ex)
            {

                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void asignarBeneficioTipoBeca(List<Beneficio> listaBeneficios, TipoBeca objTipoBeca)
        {

            try {
                BeneficioRepository.objTipoBeca = objTipoBeca;
                foreach (Beneficio objBeneficio in listaBeneficios)
                {
                  BeneficioRepository.Instance.Insert(objBeneficio);
                }
                BeneficioRepository.Instance.asignarBeneficio(objTipoBeca);
            }
            catch(Exception ex){
                throw ex;
            }
        }

        public void asignarRequisitoTipoBeca(List<Requisito> listaRequisitos, TipoBeca objTipoBeca)
        {
            try {
                RequisitoRepository.objTipoBeca = objTipoBeca;
                foreach (Requisito objRequisito in listaRequisitos)
                {
                    RequisitoRepository.Instance.Insert(objRequisito);
                }
                RequisitoRepository.Instance.asignarRequisito(objTipoBeca);
            }
            catch(Exception ex){
                throw ex;
            }
            
        }

        public void modificarTipoBeca(int idTipoBeca, string pnombre, string pestado, string pdescripcion, List<int> plistaBeneficios, List<int> plistaRequisitos)
        {
           
            try
            {
                TipoBeca objTipoBeca = ContenedorMantenimiento.Instance.crearTipoBeca(idTipoBeca, pnombre, pestado, pdescripcion);
                List<Beneficio> listaBeneficios = new List<Beneficio>();
                List<Requisito> listaRequisitos = new List<Requisito>();
                if (objTipoBeca.IsValid)
                {
                    TipoBecaRepository.Instance.Update(objTipoBeca);
                    eliminarBeneficiosTipoBeca(idTipoBeca);
                    eliminarRequisitoTipoBeca(idTipoBeca);

                    foreach (int idBeneficio in plistaBeneficios)
                    {
                        Beneficio beneficio = new Beneficio(idBeneficio);
                        listaBeneficios.Add(beneficio);
                    }

                    foreach (int idRequisito in plistaRequisitos)
                    {
                        Requisito requisito = new Requisito(idRequisito);
                        listaRequisitos.Add(requisito);
                    }
                    asignarBeneficioTipoBeca(listaBeneficios, objTipoBeca);
                    asignarRequisitoTipoBeca(listaRequisitos, objTipoBeca);
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
        public void modificarRequisitos(List<Requisito> listaRequisitos, TipoBeca objTipoBeca)
        {
            try {
                RequisitoRepository.objTipoBeca = objTipoBeca;
                foreach (Requisito objRequisito in listaRequisitos)
                {
                    RequisitoRepository.Instance.Update(objRequisito);
                }
                RequisitoRepository.Instance.asignarRequisito();
            }
            catch (Exception ex){
                throw ex;
            }
        }
        public void modificarBeneficios(List<Beneficio> listaBeneficios, TipoBeca objTipoBeca)
        {
            try {
                BeneficioRepository.objTipoBeca = objTipoBeca;
                foreach (Beneficio objBeneficio in listaBeneficios)
                {
                    BeneficioRepository.Instance.Insert(objBeneficio);
                }
                BeneficioRepository.Instance.asignarBeneficio();
            }
            catch (Exception ex){
                throw ex;
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
        public IEnumerable<Beneficio> buscarBeneficiosRelacionadosTipoBeca(int pid)
        {
            try {
                return objTipoBeca.buscarBeneficiosRelacionadosTipoBeca(pid);
            }
            catch(Exception ex){
                throw ex;
            }
        }

        public IEnumerable<Requisito> buscarRequisitosRelacionadosTipoBeca(int pid)
        {
            try {
                return objTipoBeca.buscarRequisitosRelacionadosTipoBeca(pid);
            }
            catch (Exception ex) {
                throw ex;
            }
           
        }
        public void eliminarRequisitoTipoBeca(int id)
        {
            try {
                objTipoBeca.DeleteRequisitoTipoBeca(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void eliminarBeneficiosTipoBeca(int id)
        {
            try {
                objTipoBeca.DeleteBeneficioTipoBeca(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}



