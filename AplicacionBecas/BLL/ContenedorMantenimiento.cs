using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace BLL
{

    public class ContenedorMantenimiento
    {

        private static ContenedorMantenimiento instance;
        private ContenedorMantenimiento() { }

        public static ContenedorMantenimiento Instance
        { 

            get
            {
                if (instance == null)
                {

                    instance = new ContenedorMantenimiento();
                }
                return instance;
            }
        }
        public Carrera crearObjetoCarrera(string nombre, string codigo, string color)
        {
            return new Carrera(nombre, codigo, color);
        }

        public Carrera crearObjetoCarrera(string nombre, string codigo, string color, int idCarrera)
        {
            return new Carrera(nombre, codigo, color, idCarrera);
        }

        public Carrera crearObjetoCarrera(string nombre)
        {
            return new Carrera(nombre);
        }
         //<summary> Método que se encarga de crear instancias de la clase Requisito</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "ppNombre"> variable de tipo String que almacena el nombre del requisito  </param>
        //<param name= "pdescripcion" > variable de tipo String que almacena la descripción del requisito  </param>
        //<returns>Retorna un objeto de tipo Requisito</returns> 
        public Requisito crearRequisito(string nombre, string descripcion)
        {
            return new Requisito(nombre, descripcion);
        }

         //<summary> Método que se encarga de crear instancias de la clase Usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "ppNombre"> variable de tipo String que almacena el primer nombre del usuario  </param>
        //<param name= "psNombre" > variable de tipo String que almacena el segundo nombre del usuario  </param>
        //<param name = "ppApellido"> variable de tipo String que almacena el primer apellido del usuario  </param>
        //<param name = " psApellido"> variable de tipo String que almacena el segundo apellido del usuario  </param>
        //<param name = "pidentificacion"> variable de tipo String que almacena la identificación del usuario  </param>
        //<param name = " ptelefono"> variable de tipo String que almacena el número de teléfono del usuario  </param>
        //<param name = "pfechaNacimiento">  variable de tipo Date que almacena la fecha de nacimiento del usuario  </param>
        //<param name = "prol "> variable de tipo Rol que almacena el nombre del rol del usuario  </param>
        //<param name = "pgenero"> variable de tipo int que almacena el género del usuario  </param>
        //<param name = "pcorreoElectronico"> variable de tipo String que almacena el correo electrónico del usuario  </param>
        //<param name = "pcontraseña"> variable de tipo String que almacena la contraseña del usuario  </param>
        //<returns> Retorna un objeto de tipo Usuario</returns> 

         public Usuario crearUsuario (string ppNombre,String psNombre,String ppApellido , String psApellido , String pidentificacion ,String ptelefono , DateTime pfechaNacimiento, Rol prol, int pgenero, String pcorreoElectronico, String pcontraseña)
        {
            Usuario objUsuario = new Usuario( ppNombre, psNombre, ppApellido , psApellido ,  pidentificacion , ptelefono ,pfechaNacimiento, prol,  pgenero, pcorreoElectronico,  pcontraseña);
            return objUsuario;

        }
        //<summary> Método que se encarga de crear instancias de la clase Usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "pparametro"> variable de tipo String que almacena la identificación del usuario  </param>
        //<returns> Retorna un objeto de tipo Usuario</returns> 
        public Usuario crearUsuario(String pparametro)
        {
            Usuario objUsuario = new Usuario(pparametro);
            return objUsuario;
        }

        public Beneficio crearBeneficio(String pnombre, double pporcentaje, String pasociacion)
        {
            Beneficio beneficio = new Beneficio(pnombre, pporcentaje, pasociacion);
            return beneficio;
        }

        public Beneficio crearBeneficio(int pid, String pnombre, double pporcentaje, String pasociacion)
        {

            Beneficio beneficio = new Beneficio(pnombre, pporcentaje, pasociacion);
            beneficio.Id = pid;
            return beneficio;
        }

        public Rol crearObjetoRol(int pid, String pnombre)
        {

            Rol rol = new Rol(pnombre);
            rol.Id = pid;
            return rol;
        }

        /// <summary>
        /// Crea un objeto rol
        /// </summary>
        /// <param name="nombre">nombre del rol a crear</param>
        /// <returns>devuelve el rol creado</returns>
        public Rol crearObjetoRol(string nombre)
        {
            return new Rol(nombre);
        }
    }
}
