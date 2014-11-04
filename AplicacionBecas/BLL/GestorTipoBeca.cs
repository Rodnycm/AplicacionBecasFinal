using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DAL.Repositories;

namespace BLL
{
    public class GestorTipoBeca:IGestor
    {
        //ESTA VARIABLE ES LA ACTIVIDAD QUE SE REGISTRA PARA LA BITACORA DE ACCIONES, NO BORRAR
        public string actividad;

    
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
        public void agregarTipoBeca(string nombre, string estado, string descripcion)
        {
            TipoBeca objTipoBeca = new TipoBeca(nombre, estado, descripcion);

            try
            {
                if (objTipoBeca.IsValid)
                {
                    TipoBecaRepository.Instance.Insert(objTipoBeca);
                    //Setea la actividad, llama al metodo registrar accion
                     actividad = "Se ha registrado un Tipo De Beca";
                    registrarAccion(actividad);
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
        /// <summary>
        /// Se llama al método GetAll del repositorio y este recibe una lista con los tipos de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <returns>Retorna una lista de los tipos de beca</returns>
        public IEnumerable<TipoBeca> consultarTipoBeca()
        {
            return TipoBecaRepository.Instance.GetAll();
        }

        /// <summary>
        /// Llama al método Save del repository
        ///</summary>
        ///<author>María Jesús Gutiérrez</author>
        public void guardarCambios()
        {

            TipoBecaRepository.Instance.Save();
        }

        public void registrarAccion(String pactividad) {

            RegistroAccion objRegistro;
            DateTime fecha = DateTime.Today;
            string nombreUsuario;
            string nombreRol = "Decano";
            string descripcion = pactividad;
            //nombreUsuario = Globals.userName;
            nombreUsuario = "Pedro";


            objRegistro = new RegistroAccion(nombreUsuario, nombreRol, descripcion, fecha);

            RegistroAccionRepository objRegistroRep = new RegistroAccionRepository();

            objRegistroRep.InsertAccion(objRegistro);

        }
    }
}