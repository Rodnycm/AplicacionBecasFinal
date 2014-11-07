using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DAL.Repositories;

namespace BLL
{
    public class GestorRequisito
    {
        //<summary> Método que se encarga de un nuevo Requisito</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "pNombre"> variable de tipo String que almacena el nombre del requisito  </param>
        //<param name= "pdescripcion" > variable de tipo String que almacena la descripción del requisito  </param>
        //<returns>No retorna valor</returns> 
        public void crearRequisito(String pnombre, String pdescripcion)
        {
            try
            {
                Requisito objRequisito = ContenedorMantenimiento.Instance.crearRequisito(pnombre, pdescripcion);
                if (objRequisito.IsValid)
                {
                    RequisitoRepository.Instance.Insert(objRequisito);
                    //UoW.RequisitoRepository.Insert(objRequisito);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objRequisito.GetRuleViolations())
                    {
                        sb.Append(rv.ErrorMessage);
                    }
                    new ApplicationException(sb.ToString());
                    
                }
            }

            catch (Exception ex)
            {
                
            }
        }


        public IEnumerable<Requisito> consultarRequisitos()
        {

            return RequisitoRepository.Instance.GetAll();

        }

        public Requisito buscarRequisito(String param)
      {
            return RequisitoRepository.Instance.GetByNombre(param);
        }

        //public IEnumerable<Requisito> mostrarRequisitoTB(TipoBeca ptipoBeca)
        //{

        //    return RequisitoRepository.Instance.GetLista(ptipoBeca);
        //}

        //<summary> Método que se encarga de modificcar un requisito</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param name = "pnombre"> variable de tipo String que almacena el nombre del requisito  </param>
        //<param name = "pdescripcion"> variable de tipo String que almacena la descripción del requisito</param>
        //<param name = "pid"> variable de tipo int que almacena el id del requisito</param>
        //<returns> No retorna valor </returns> 
        public void modificarRequisito(String pnombre,String pdescripcion,int pid){

            try{
                Requisito objRequisito = ContenedorMantenimiento.Instance.crearRequisito(pnombre,pdescripcion,pid);
                RequisitoRepository.Instance.Update(objRequisito);
            }
            catch (Exception ex){

                throw ex;
            }
        }


        //<summary> Método que se encarga de guardar los cambios de un requisito</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param> No recibe parametros  </param>
        //<returns> No retorna valor </returns> 
        public void guardarCambios()
        {
            RequisitoRepository.Instance.Save();

        }
    }
}
