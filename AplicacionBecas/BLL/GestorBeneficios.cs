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
    public class GestorBeneficios:IGestor
    {
        public string actividad;
    
        //private BeneficioRepository repBeneficio;
        /// <summary>
        /// Este método recive los parametros necesarios para instanciar un beneficio.
        /// Enviá los parametros para crear el beneficio y recibe una instancia.
        /// Envía el nuevo objeto al repositorio para que se guarde en la lista de ítems respectiva.
        /// El objeto se envia para que luego sea insertado en la base de datos.
        /// Atrapa una excepcion en caso de error.
        /// </summary>
        /// <author>Mathias Muller</author>
        /// <param name="pnombre">Es el nombre del beneficio</param>
        /// <param name="pporcentaje">Es el porcentaje que cubre el beneficio</param>
        /// <param name="paplicacion">Describe a que se aplica el beneficio</param>

        public void agregarBeneficio(string pnombre, double pporcentaje, string pasociacion)
        {


            Beneficio objBeneficio = ContenedorMantenimiento.Instance.crearBeneficio(pnombre, pporcentaje, pasociacion);

            try
            {
                if (objBeneficio.IsValid)
                {

                    BeneficioRepository.Instance.Insert(objBeneficio);
                     actividad = "Se ha registrado un Beneficio";
                    registrarAccion(actividad);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objBeneficio.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new ApplicationException(sb.ToString());
                }
            }
            catch (Exception e)
            {


                String error = e.ToString();

                System.Console.Write(error);
                throw new ApplicationException("Noooooo");
            }
        }
        /// <summary>
        /// Este método recive los parametros necesarios para instanciar un beneficio.
        /// Enviá los parametros para crear el beneficio y recibe una instancia.
        /// Envía el nuevo objeto al repositorio para que se guarde en la lista de ítems respectiva.
        /// El objeto se envia para que luego sea modificado en la base de datos.
        /// Atrapa una excepcion en caso de error.
        /// </summary>
        /// <author>Mathias Muller</author>
        /// <param name="pnombre">Es el nombre del beneficio</param>
        /// <param name="pporcentaje">Es el porcentaje que cubre el beneficio</param>
        /// <param name="paplicacion">Describe a que se aplica el beneficio</param>

        public void modificarBeneficio(int pid, string pnombre, double pporcentaje, string pasociacion)
        {
            Beneficio objBeneficio = ContenedorMantenimiento.Instance.crearBeneficio(pid, pnombre, pporcentaje, pasociacion);

            try
            {
                if (objBeneficio.IsValid)
                {
                    BeneficioRepository.Instance.Update(objBeneficio);
                     actividad = "Se ha modificado un Beneficio";
                    registrarAccion(actividad);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objBeneficio.GetRuleViolations())
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
        /// Este método recive los parametros necesarios para instanciar un beneficio.
        /// Enviá los parametros para crear el beneficio y recibe una instancia.
        /// Envía el nuevo objeto al repositorio para que se guarde en la lista de ítems respectiva.
        /// El objeto se envia para que luego sea eliminado de la base de datos.
        /// Atrapa una excepcion en caso de error.
        /// </summary>
        /// <author>Mathias Muller</author>
        /// <param name="pnombre">Es el nombre del beneficio</param>
        /// <param name="pporcentaje">Es el porcentaje que cubre el beneficio</param>
        /// <param name="paplicacion">Describe a que se aplica el beneficio</param>

        public void eliminarBeneficio(int pid, string pnombre, double pporcentaje, string pasociacion)
        {
            Beneficio objBeneficio = ContenedorMantenimiento.Instance.crearBeneficio(pid, pnombre, pporcentaje, pasociacion);
            try
            {

                BeneficioRepository.Instance.Delete(objBeneficio);
                 actividad = "Se ha eliminado un Beneficio";
                    registrarAccion(actividad);
            }

            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Llama al método Save() del repositorio.
        /// Atrapa una excepción en caso de error.
        /// </summary>
        /// <author>Mathias Muller</author>

        public void guardarCambios()
        {
            //try
            //{
            BeneficioRepository.Instance.Save();
            //}
            //catch (DataAccessException ex)
            //{
            //    throw ex;
            //}
            //catch (Exception ex)
            //{
            //    //logear a la bd
            //    throw new BusinessLogicException("Ha ocurrido un error al eliminar un usuario", ex);
            //}
        }

        /// <summary>
        /// Llama al método getAll() del repositorio y recibe una lista de beneficios.
        /// </summary>
        /// <author>Mathias Muller</author>
        /// <returns>Una Lista de beneficios</returns>

        public IEnumerable<Beneficio> buscarBeneficios()
        {
            return BeneficioRepository.Instance.GetAll();
        }
        /// <summary>
        /// Llama al método GetByNombre() del repositorio y recibe una instancia de un beneficio.
        /// </summary>
        /// <author>Mathias Muller</author>
        /// <returns>Un Objeto Beneficio</returns>

        public Beneficio buscarPorNombre(String pnombre)
        {
            return BeneficioRepository.Instance.GetByNombre(pnombre);
        }

        public void registrarAccion(string pactividad)
        {

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
