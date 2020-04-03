using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecog
{
    public partial class Registro_de_personas : Form
    {
        public Registro_de_personas()
        {
            InitializeComponent();
        }

        string cs = @"Data Source=DESKTOP-5CRRC6C\SQLEXPRESS;Initial Catalog=MyDatabase;Integrated Security=True";

        private void btnBackLP_Click(object sender, EventArgs e)
        {


            
            this.Close();
        }

        private void btnRegisterLP_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("C:/Users/Enmri/Desktop/Images/"+txtName.Text+".jpg", ImageFormat.Jpeg);

            if (txtName.Text == "" || txtLName.Text == "" || txtLastPlace.Text == "" || txtState.Text=="")
            {
                MessageBox.Show("Porfavor escribe un nombre de usuario y contraseña");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into tbl_lostPerson values(@name, @lname, @lplace, @state)", con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@lname", txtLName.Text);
                cmd.Parameters.AddWithValue("@lplace", txtLastPlace.Text);
                cmd.Parameters.AddWithValue("@state", txtState.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Registro_de_personas_FormClosed(object sender, FormClosingEventArgs e)
        {


            PaginaPrincipal pgP = new PaginaPrincipal();
            pgP.Show();
        }

        private void btnImgUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
