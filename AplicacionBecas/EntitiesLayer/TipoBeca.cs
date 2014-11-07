using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace EntitiesLayer
{
    public class TipoBeca : IEntity
    {

        //public int id { get; set; }
        private int _idTipoBeca;
       /// <summary>
       /// Declaración de la variable id
       /// </summary>
        public int Id
        {
            get { return _idTipoBeca; }
            set { _idTipoBeca = value; }
        }
        public string nombre { get; set; }
        public string estado { get; set; }
        public string descripcion { get; set; }
        public DateTime objD { get; set; }
        private List<Beneficio> listaBeneficios { get; set; }
        private List<Requisito> listaRequisitos { get; set; }

        /// <summary>
        /// Constructor TipoBeca que crea una instancia de un TipoBeca.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="pnombre">Nombre del tipo de beca</param>
        /// <param name="pestado">Estado del tipo de beca</param>
        /// <param name="pdescripcion">Descripción del tipo de beca</param>
        public TipoBeca(int pid, String pnombre, DateTime pobjD, String pestado, String pdescripcion)
        {
            Id = pid;
            nombre = pnombre;
            estado = pestado;
            descripcion = pdescripcion;
            objD = pobjD;
        }


        public TipoBeca(String pnombre, String pestado, String pdescripcion)
         :   this(0,pnombre,System.DateTime.Now,pestado,pdescripcion)
        {
        }
        public TipoBeca(String pnombre)
        {
            nombre = pnombre;
        }

        /// <summary>
        /// Método que hace un get de lo que retorna el RuleViolationes
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        /// <summary>
        /// Método que atrapa las excepciones de la base de datos.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <returns>Retorna un RuleViolation (mensaje de error)</returns>
       
       public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (String.IsNullOrEmpty(nombre))
            {
                yield return new RuleViolation("Nombre Requerido", "nombre");
            }
             if (String.IsNullOrEmpty(estado))
            {
                yield return new RuleViolation("Estado Requerido", "estado");
            }
            if (String.IsNullOrEmpty(descripcion))
            {
                yield return new RuleViolation("Descripcion Requerido", "descripcion");
            }

            if (!(Regex.IsMatch(nombre, "^[\\p{L} .'-]+$")))
            {
                yield return new RuleViolation("Datos no váldios","Nombre");
            }

            if (!(Regex.IsMatch(estado, "^[\\p{L} .'-]+$")))
            {
                yield return new RuleViolation("Datos no váldios", "Estado");
            }

            if (!(Regex.IsMatch(descripcion, "^[\\p{L} .'-]+$")))
            {
                yield return new RuleViolation("Datos no váldios", "Descripción");
            }

            yield break;
            }
        } 
   }


