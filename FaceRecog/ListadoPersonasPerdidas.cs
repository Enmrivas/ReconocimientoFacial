using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecog
{
    public partial class ListadoPersonasPerdidas : Form
    {
        public ListadoPersonasPerdidas()
        {
            InitializeComponent();
            showdata();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5CRRC6C\SQLEXPRESS;Initial Catalog=MyDatabase;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;


        public void showdata()
        {
            adpt = new SqlDataAdapter("select * from tbl_lostPerson", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void ListadoPersonasPerdidas_FormClosed(object sender, FormClosedEventArgs e)
        {


            PaginaPrincipal pgP = new PaginaPrincipal();
            pgP.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                Detalles dets = new Detalles(dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
                dets.Show();
                this.Hide();
            }
        }
    }
}
