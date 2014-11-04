using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EntitiesLayer
{
    public class TipoBeca : IEntity
    {
        public int id { get; set; }
        private int _idTipoBeca;
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

        /// <summary>
        /// Constructor default de TipoBeca
        /// No recibe ningún parámetro
        /// Crea una instancia de la clase.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        public TipoBeca()
        {
            nombre = "";
            estado = "";
            descripcion = "";
        }

        /// <summary>
        /// Constructor TipoBeca que crea una instancia de un TipoBeca.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="pnombre">Nombre del tipo de beca</param>
        /// <param name="pestado">Estado del tipo de beca</param>
        /// <param name="pdescripcion">Descripción del tipo de beca</param>
        public TipoBeca(String pnombre, String pestado, String pdescripcion)
        {
            nombre = pnombre;
            estado = pestado;
            descripcion = pdescripcion;
            objD = DateTime.Now.Date;
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
                yield return new RuleViolation("Descripcion Requerido", "estado");
            }

            yield break;
        }
    }
}
