
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTesting
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.passwordTextBox.AutoSize = false;
            this.passwordTextBox.Size = new Size(passwordTextBox.Width, LoginTextBox.Height);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
            CloseButton.BackColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
            CloseButton.BackColor = Color.FromArgb(203, 212, 178);
        }
        //Point lastPoint;
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //  this.Left += e.X /*- lastPoint.X*/;
            //  this.Height += e.Y /*- lastPoint.Y*/;
            TopPanel.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);

            //}
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            String userLogging = LoginTextBox.Text;
            String userPassword = passwordTextBox.Text;
            DB dB = new DB();
        
            DataTable dT = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM user WHERE login = @uL AND password = @uP", dB.GetConnection());
            cmd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogging;
            cmd.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPassword;
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dT);
            if (dT.Rows.Count > 0)
            {
                MessageBox.Show("Succes");
            }
            else
            {
                MessageBox.Show("Fail, There is no such user");
            }
        }

        private void registrationLabel_Click(object sender, EventArgs e)
        {
           this.Hide();
            RegistrationForm registerForm = new RegistrationForm();
                registerForm.Show();

        }

        //private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        //{

        //        lastPoint = new Point(this.Left, this.Right);


        //}
    }
}
