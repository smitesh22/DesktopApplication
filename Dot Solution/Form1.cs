using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace Dot_Solution
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

           
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                                    "Password=Smitesh98.*;Database=website;");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("select email,is_superuser,username,password from auth_user;", conn);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0].Equals(username) || dr[2].Equals(username) && dr[1].Equals(true))
                {
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                }
            }

            change.Text = "Credentials Invalid! Login Again";
            System.Drawing.Color myColor = System.Drawing.ColorTranslator.FromHtml("Red");
            change.ForeColor = myColor;

            conn.Close();

            
        }
    }
}
