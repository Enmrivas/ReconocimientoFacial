using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecog
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegPers_Click(object sender, EventArgs e)
        {


            Registro_de_personas regPers = new Registro_de_personas();
            regPers.Show();
            this.Hide();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListadoPersonasPerdidas listPers = new ListadoPersonasPerdidas();
            listPers.Show();
            this.Hide();
        }

        private void PaginaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
