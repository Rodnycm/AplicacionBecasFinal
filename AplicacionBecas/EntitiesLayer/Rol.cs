using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;


namespace EntitiesLayer
{
    public class Rol : IEntity
    {

        private int idRol;
        private List<Permiso> listaPermisos = new List<Permiso>();
        public int Id
        {
            get { return idRol; }
            set { idRol = value; }
        }

        public String Nombre { get; set; }

        /// <summary>
        /// Crea un nuevo rol sin parametros
        /// </summary>
        public Rol()
        {

            Nombre = "";

        }

        /// <summary>
        /// Crea un nuevo Rol
        /// </summary>
        /// <param name="pNombre">nombre del rol</param>
        public Rol(String pNombre)
        {
            Nombre = pNombre;
        }

        /// <summary>
        /// Trae la lista de permisos del rol
        /// </summary>
        /// <returns>reporta la lista de permisos</returns>
        public List<Permiso> getListaPermisos()
        {

            return listaPermisos;

        }

        /// <summary>
        /// SETEA los permisos de el rol
        /// </summary>
        /// <param name="plistaPermisos">la nueva lista de permisos</param>
        public void setListaPermisos(List<Permiso> plistaPermisos)
        {

            listaPermisos = plistaPermisos;
        }

        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }


        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                yield return new RuleViolation("Nombre Requerido", "Nombre");
            }


            yield break;
        }


    }
}




