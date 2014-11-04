using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using DAL;
using DAL.Repositories;

namespace BLL
{

    public class GestorCarrera
    {

        public void agregarCarrera(string nombre, string codigo, string color, string idDirector)
        {
            Usuario director = UsuarioRepository.Instance.GetByNombre(idDirector);
            Carrera carrera = ContenedorMantenimiento.Instance.crearObjetoCarrera(nombre, codigo, color, director);
            try
            {
                if (carrera.IsValid)
                {

                    CarreraRepository.Instance.Insert(carrera);

                }
                else {

                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in carrera.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new ApplicationException(sb.ToString());
                
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable <Usuario> consultarDirectoresAcademicos() {

            return UsuarioRepository.Instance.GetDirectoresAcademicos();
        
        }

        public void modificarCarrera(string nombre, string codigo, string color, int idCarrera, string idDirector ,string directorAntiguo)
        {
            Usuario director = UsuarioRepository.Instance.GetByNombre(idDirector);
            Usuario antiguo = UsuarioRepository.Instance.GetByNombre(directorAntiguo);
            Carrera carrera = ContenedorMantenimiento.Instance.crearObjetoCarrera(nombre, codigo, color, idCarrera, director);

            try
            {
                if(carrera.IsValid){
                    CarreraRepository.Instance.UpdateCarrera(carrera, antiguo);
                }else{
                    
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in carrera.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new ApplicationException(sb.ToString());
                }
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Carrera buscarCarrera(String param)
        {
            return CarreraRepository.Instance.GetByNombre(param);
        }

        public void eliminarCarrera(String codigo)
        {

            Carrera carrera = ContenedorMantenimiento.Instance.crearObjetoCarrera(codigo);

            try
            {
                if (carrera.IsValid)
                {

                    CarreraRepository.Instance.Delete(carrera);
                }
                else {

                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in carrera.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new ApplicationException(sb.ToString());
                
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Carrera> consultarCarreras()
        {

            return CarreraRepository.Instance.GetAll();

        }

        public void guardarCambios()
        {

            CarreraRepository.Instance.Save();
        }
    }
}


