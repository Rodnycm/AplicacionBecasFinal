
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Carrera : IEntity
    {

        private int _idCarrera;

        public int Id
        {
            get { return _idCarrera; }
            set { _idCarrera = value; }
        }

        public String nombre { get; set; }
        public String codigo { get; set; }
        public String color { get; set; }
        public String directorAcademico { get; set; }

        public Carrera()
        {

            nombre = "";
            codigo = "";
            color = "";
            directorAcademico = "";

        }

        public Carrera(String pNombre, String pCodigo, String pColor, String pDirectorAcademico)
        {
            nombre = pNombre;
            codigo = pCodigo;
            color = pColor;
            directorAcademico = pDirectorAcademico;
        }

        public Carrera(String pNombre, String pCodigo, String pColor)
        {
            nombre = pNombre;
            codigo = pCodigo;
            color = pColor;
            directorAcademico = "";
        }

        public Carrera(String pNombre, String pCodigo, String pColor, int pidCarrera)
        {
            nombre = pNombre;
            codigo = pCodigo;
            color = pColor;
            directorAcademico = "";
            _idCarrera = pidCarrera;
        }

        public Carrera(String pCodigo)
        {
            nombre = "";
            codigo = pCodigo;
            color = "";
        }
    }
}



