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
    public partial class BusquedaAPI : Form
    {
        string ide;
        public BusquedaAPI(string id)
        {
            InitializeComponent();
            ide = id;
            showData(id);
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5CRRC6C\SQLEXPRESS;Initial Catalog=MyDatabase;Integrated Security=True");
        public void showData(string id)
        {
            SqlCommand cmd = new SqlCommand("Select * from tbl_lostPerson where ID = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            
            imgLost.Image = new Bitmap("C:/Users/Enmri/Desktop/Images/" + dt.Rows[0]["Nombre"].ToString() + ".jpg");
            imgLost.SizeMode = PictureBoxSizeMode.StretchImage;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BusquedaAPI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Edit edit = new Edit(ide);
            edit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                imgTest.Image = new Bitmap(opnfd.FileName);
                imgTest.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
