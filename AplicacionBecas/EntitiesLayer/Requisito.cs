using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace EntitiesLayer
{
    public class Requisito : IEntity
    {

        //<summary> Métodos set y get de la variable nombre</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > variable de tipo String que almacena el nombre</param>
        //<returns> Retorna una variable String con el nombre del requisito.</returns> 
        public String nombre { get; set; }

        //<summary> Métodos set y get de la variable descripcion</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > variable de tipo String que almacena el descripcion</param>
        //<returns> Retorna una variable String con la descripcion del requisito.</returns> 
        public String descripcion { get; set; }
        private int idRequisito;

        //<summary> Métodos set y get de la variable idRequisito</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > variable de tipo int que almacena el id del requisito</param>
        //<returns> Retorna una variable int con el id del requisito.</returns> 
        public int Id
        {
            get { return idRequisito; }
            set { idRequisito = value; }
        }

        //<summary> Constructor de la clase Requisito</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > No recibe parámetros</param>
        //<returns> No retorna valor.</returns> 
        public Requisito()
        {
            Id = 0;
            nombre = "";
            descripcion = "";
        }

        //<summary> Constructor de la clase Requisito</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "ppNombre"> variable de tipo String que almacena el nombre del requisito  </param>
        //<param name= "pdescripcion" > variable de tipo String que almacena la descripción del requisito  </param>
        //<returns> No retorna valor.</returns> 
        public Requisito(String pnombre, String pdescripcion)
        {
            Id = 0;
            nombre = pnombre;
            descripcion = pdescripcion;
        }

        //<summary> Método que se encarga de determinar si los datos ingresados del requisito son validos</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > No recibe parámetros </param>
        //<returns> Variable booleana </returns> 
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }


        //<summary> Método que se encarga de validar que los diferentes atributos del requisito esten correctos</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > No recibe parámetros </param>
        //<returns> Retorna una lista de objetos RuleViolation </returns> 
        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (String.IsNullOrEmpty(nombre))
            {
                yield return new RuleViolation("Nombre Requerido", "nombre");
            }

            if (String.IsNullOrEmpty(descripcion))
            {
                yield return new RuleViolation("Descripción Requerida", "descripción");
            }

            if (!(Regex.IsMatch(nombre, "^[a-zA-Z]+$")))
            {
                yield return new RuleViolation("ERROR", "Nombre incorrecto");
            }

            yield break;
        }
    }
}
