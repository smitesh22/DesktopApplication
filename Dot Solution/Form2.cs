using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Dot_Solution
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                                  "Password=Smitesh98.*;Database=website;");
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,username,email,last_login FROM auth_user;", conn);
            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewUsers.DataSource = dt;
                dataGridViewUsers.Visible = true;
                Blank.Text = "Table returned";
                System.Drawing.Color myColor = System.Drawing.ColorTranslator.FromHtml("Green");
                Blank.ForeColor = myColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ViewFlagged_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                                  "Password=Smitesh98.*;Database=website;");
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT auth_user.id,username,email,flagged.count FROM auth_user INNER JOIN flagged ON auth_user.id = flagged.id;", conn);
            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewUsers.DataSource = dt;
                dataGridViewUsers.Visible = true;
                Blank.Text = "Table returned";
                System.Drawing.Color myColor = System.Drawing.ColorTranslator.FromHtml("Green");
                Blank.ForeColor = myColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                                  "Password=Smitesh98.*;Database=website;");
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM blog_post;", conn);
            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewUsers.DataSource = dt;
                dataGridViewUsers.Visible = true;
                Blank.Text = "Table returned";
                System.Drawing.Color myColor = System.Drawing.ColorTranslator.FromHtml("Green");
                Blank.ForeColor = myColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int index = int.Parse(listBox1.GetItemText(listBox1.SelectedIndex)) + 1;

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=Smitesh98.*;Database=website;"))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT flagged.id,username,email,date_joined FROM auth_user INNER JOIN flagged ON auth_user.id = flagged.id WHERE count<=" + index + ";", conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    using (NpgsqlConnection conn1 = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=Smitesh98.*;Database=website;"))
                    {
                        conn1.Open();
                        NpgsqlCommand ins = new NpgsqlCommand("INSERT INTO BLACKLISTED(id,username,email,date_joined)values(@id,@username,@email,@date_joined)", conn1);
                        ins.Parameters.AddWithValue("@id", reader["id"]);
                        ins.Parameters.AddWithValue("@username", reader["username"]);
                        ins.Parameters.AddWithValue("@email", reader["email"]);
                        ins.Parameters.AddWithValue("@date_joined", reader["date_joined"]);

                        ins.ExecuteNonQuery();
                        conn1.Close();
                    }


                    using (NpgsqlConnection conn2 = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=Smitesh98.*;Database=website;"))
                    {
                        conn2.Open();
                        NpgsqlCommand del_blog_post = new NpgsqlCommand("DELETE FROM blog_post WHERE author_id = " + reader["id"], conn2);
                        NpgsqlCommand del_flagged = new NpgsqlCommand("DELETE FROM flagged WHERE id = " + reader["id"], conn2);
                        NpgsqlCommand del_auth_user = new NpgsqlCommand("DELETE FROM auth_user WHERE id = " + reader["id"], conn2);
                        NpgsqlCommand del_auth_user_profile = new NpgsqlCommand("DELETE FROM users_profile WHERE user_id = " + reader["id"], conn2);
                        del_blog_post.ExecuteNonQuery();
                        del_flagged.ExecuteNonQuery();
                        del_auth_user_profile.ExecuteNonQuery();
                        del_auth_user.ExecuteNonQuery();
                        conn2.Close();
                    }  
                    
                }
                reader.Close();
                conn.Close();
            }
            

           
           
        }
        private void run_cmd()
        {  // Set working directory and create process
            var workingDirectory = Path.GetFullPath(@"C:\Users\Python");
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    RedirectStandardOutput = true,
                    WorkingDirectory = workingDirectory
                }
            };
            process.Start();
            
            using (var sw = process.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine(@"C:\Users\HEISENBERG\Anaconda3\Scripts\activate.bat");
                    sw.WriteLine("activate base");
                    sw.WriteLine("python flag.py");
                }
            }

            while (!process.StandardOutput.EndOfStream)
            {
                var line = process.StandardOutput.ReadLine();
                System.Diagnostics.Debug.WriteLine(line);
            }

        }
        private void FlagUser_Click(object sender, EventArgs e)
        {
            run_cmd();
            
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
