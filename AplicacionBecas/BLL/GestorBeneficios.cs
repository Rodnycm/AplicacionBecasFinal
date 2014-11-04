using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DAL;
using DAL.Repositories;
<<<<<<< HEAD
using TIL;
using System.Data.SqlClient;
=======
>>>>>>> origin/prophet94


namespace BLL
{
<<<<<<< HEAD
    public class GestorBeneficios
    {
        public string actividad;

=======
    public class GestorBeneficios:IGestor
    {
        public string actividad;
    
>>>>>>> origin/prophet94
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
<<<<<<< HEAD

=======
                     actividad = "Se ha registrado un Beneficio";
                    registrarAccion(actividad);
>>>>>>> origin/prophet94
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
<<<<<<< HEAD
                throw e;
=======


                String error = e.ToString();

                System.Console.Write(error);
                throw new ApplicationException("Noooooo");
>>>>>>> origin/prophet94
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
<<<<<<< HEAD
=======
                     actividad = "Se ha modificado un Beneficio";
                    registrarAccion(actividad);
>>>>>>> origin/prophet94
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
<<<<<<< HEAD
            catch (Exception e)
            {
                throw e;
=======
            catch (Exception)
            {

                throw;
>>>>>>> origin/prophet94
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
<<<<<<< HEAD
            }

            catch (Exception e)
            {

                throw e;
=======
                 actividad = "Se ha eliminado un Beneficio";
                    registrarAccion(actividad);
            }

            catch (Exception)
            {
                throw;
>>>>>>> origin/prophet94
            }
        }

        /// <summary>
        /// Llama al método Save() del repositorio.
        /// Atrapa una excepción en caso de error.
        /// </summary>
        /// <author>Mathias Muller</author>

        public void guardarCambios()
        {
<<<<<<< HEAD
            try
            {
                BeneficioRepository.Instance.Save();
            }
=======
            //try
            //{
            BeneficioRepository.Instance.Save();
            //}
>>>>>>> origin/prophet94
            //catch (DataAccessException ex)
            //{
            //    throw ex;
            //}
<<<<<<< HEAD
            catch (Exception e)
            {
                throw e;
            }
=======
            //catch (Exception ex)
            //{
            //    //logear a la bd
            //    throw new BusinessLogicException("Ha ocurrido un error al eliminar un usuario", ex);
            //}
>>>>>>> origin/prophet94
        }

        /// <summary>
        /// Llama al método getAll() del repositorio y recibe una lista de beneficios.
        /// </summary>
        /// <author>Mathias Muller</author>
        /// <returns>Una Lista de beneficios</returns>

        public IEnumerable<Beneficio> buscarBeneficios()
        {
<<<<<<< HEAD
            try
            {
                return BeneficioRepository.Instance.GetAll();
            }
            //catch (DataAccessException ex)
            //{
            //    throw ex;
            //}
            catch (Exception e)
            {
                throw e;
            }

=======
            return BeneficioRepository.Instance.GetAll();
>>>>>>> origin/prophet94
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
<<<<<<< HEAD
=======

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

>>>>>>> origin/prophet94
    }
}
