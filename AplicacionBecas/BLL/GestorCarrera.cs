using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using DAL;

namespace BLL
{

    public class GestorCarrera
    {

        public void agregarCarrera(string nombre, string codigo, string color)
        {

            try
            {
                CarreraRepository.Instance.Insert(ContenedorMantenimiento.Instance.crearObjetoCarrera(nombre, codigo, color));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void modificarCarrera(string nombre, string codigo, string color, int idCarrera)
        {

            try
            {
                CarreraRepository.Instance.Update(ContenedorMantenimiento.Instance.crearObjetoCarrera(nombre, codigo, color, idCarrera));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void eliminarCarrera(String codigo)
        {

            try
            {
                CarreraRepository.Instance.Delete(ContenedorMantenimiento.Instance.crearObjetoCarrera(codigo));
            }
            catch (Exception)
            {

                throw;
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

