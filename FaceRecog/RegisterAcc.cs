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
    public partial class RegisterAcc : Form
    {
        public RegisterAcc()
        {
            InitializeComponent();
        }

        string cs = @"Data Source=DESKTOP-5CRRC6C\SQLEXPRESS;Initial Catalog=MyDatabase;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Porfavor escribe un nombre de usuario y contraseña");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into tbl_Login values(@email, @username, @password, @admin)", con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@admin", "false");

                cmd.ExecuteNonQuery();

                con.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterAcc_FormClosed(object sender, FormClosedEventArgs e)
        {

            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
