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
    public partial class Edit : Form
    {
        string ide;
        public Edit(string id)
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
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["Nombre"].ToString();
                txtLName.Text = dt.Rows[0]["Apellido"].ToString();
                txtLPlace.Text = dt.Rows[0]["UltimoLugar"].ToString();
                txtState.Text = dt.Rows[0]["Estado"].ToString();
            }
            pictureBox1.Image = new Bitmap("C:/Users/Enmri/Desktop/Images/" + txtName.Text + ".jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update tbl_lostPerson set Nombre = @name, Apellido = @lname, UltimoLugar = @lplace, Estado = @state where id = @id", con);
            cmd.Parameters.AddWithValue("@id", ide);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@lname", txtLName.Text);
            cmd.Parameters.AddWithValue("@lplace", txtLPlace.Text);
            cmd.Parameters.AddWithValue("@state", txtState.Text);

            cmd.ExecuteNonQuery();
            con.Close();


            pictureBox1.Image.Save("../../Imagnes/" + txtName.Text + ".jpg");
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Detalles detalles = new Detalles(ide);
            detalles.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
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
