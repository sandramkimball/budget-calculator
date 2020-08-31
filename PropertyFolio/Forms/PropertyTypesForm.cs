using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PropertyFolio
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UsernameInput_Enter(object sender, EventArgs e)
        {
            LoginFailLabel.Visible = false;
        }

        private void PasswordInput_Enter(object sender, EventArgs e)
        {
            LoginFailLabel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UsernameAstrick.Visible = false;
            PasswordAstrick.Visible = false;
            LoginFailLabel.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameInput.Text;
            string password = PasswordInput.Text;
            Class.FUNC func = new Class.FUNC();

            if (checkFields())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @un AND passsword=@pass");
                command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
                DataTable table = func.getData(command);

                if (table.Rows.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    UsernameAstrick.Visible = false;
                    PasswordAstrick.Visible = false;
                    LoginFailLabel.Visible = false;
                }
                else
                {
                    UsernameAstrick.Visible = true;
                    PasswordAstrick.Visible = true;
                    LoginFailLabel.Visible = true;
                }
            }
            else 
            {
                UsernameAstrick.Visible = true;
                PasswordAstrick.Visible = true;
                LoginFailLabel.Visible = true;
            };
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Boolean checkFields() 
        {
            if (UsernameInput.Text.Trim().Equals("") ||
                PasswordInput.Text.Trim().Equals(""))
            {               
                return false;
            }

            return true;
        }

        private void UsernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginFailLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
