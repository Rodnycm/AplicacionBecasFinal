
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public partial class Alerts : Form
    {
        public Alerts()
        {
            InitializeComponent();
        }

        static Alerts alerta; static DialogResult result = DialogResult.No;

        public static DialogResult Show(String Text)
        {
            alerta = new Alerts();
            alerta.label1.Text = Text;
            alerta.btnAceptar.Text = "Aceptar";
            alerta.ShowDialog();
            alerta.BringToFront();
            return result;

        }


        private void Alerts_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            result = DialogResult.Yes; alerta.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; alerta.Close();
        }


    }
}
