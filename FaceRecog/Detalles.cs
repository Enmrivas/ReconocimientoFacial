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
    public partial class Detalles : Form
    {
        string id;
        public Detalles(string v)
        {
            InitializeComponent();
            id = v;
            showData(v);
        }



        public void showData(string id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5CRRC6C\SQLEXPRESS;Initial Catalog=MyDatabase;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from tbl_lostPerson where ID = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["Nombre"].ToString();
                txtLName.Text = dt.Rows[0]["Apellido"].ToString();
                txtLastPlace.Text = dt.Rows[0]["UltimoLugar"].ToString();
                txtState.Text = dt.Rows[0]["Estado"].ToString();
            }
            pictureBox1.Image = new Bitmap("../../Imagenes/" + txtName.Text + ".jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            con.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            BusquedaAPI busquedaAPI = new BusquedaAPI(id);
            busquedaAPI.Show();
            this.Hide();
        }

        private void Detalles_FormClosed(object sender, FormClosedEventArgs e)
        {

            ListadoPersonasPerdidas list = new ListadoPersonasPerdidas();
            list.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            Edit edit = new Edit(id);
            edit.Show();
            this.Hide();
        }
    }
}
