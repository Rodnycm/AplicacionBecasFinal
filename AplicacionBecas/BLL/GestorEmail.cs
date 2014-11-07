using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using DAL;
using DAL.Repositories;

namespace BLL
{
    public class GestorEmail
    {

        public Email getEmail()
        {
            return EmailRepository.Instance.GetEmail();
        }

        public void modificarEmail(String pemisor, String pasunto, String pmensaje, String psmtpServidor, String puserName, String pcontrasenna, int id)
        {
            Email email = ContenedorMantenimiento.Instance.crearObjetoEmail(pemisor, pasunto, pmensaje, psmtpServidor, puserName, pcontrasenna,id);
            EmailRepository.Instance.UpdateEmail(email);
        }
    }
}
