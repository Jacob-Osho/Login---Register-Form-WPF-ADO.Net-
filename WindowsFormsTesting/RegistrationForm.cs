using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsTesting
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.passwordTextBox.AutoSize = false;
            this.passwordTextBox.Size = new Size(passwordTextBox.Width, registerLoginTextBox.Height);
            this.confirmPasswordTextBox.AutoSize = false;
            this.confirmPasswordTextBox.Size = new Size(confirmPasswordTextBox.Width, registerLoginTextBox.Height);
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
        private static string FirstLetterToUpper(string name)
        {
           if(string.IsNullOrEmpty(name))
                return name;
         
            char [] temp  = new char[name.Length];
             temp   = name.ToCharArray();
            temp[0] = char.ToUpper(temp[0]);
            string result = new string(temp);
            return result;
        }
        public static bool IsUserExists(string login,string email,out string message)
        {
            string messegeTxt=String.Empty;
            bool result = false;
            DB dB = new DB();
            DataTable dT = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
    
            MySqlCommand cmd2 = new MySqlCommand($"SELECT * FROM user WHERE login = @uL", dB.GetConnection());
            cmd2.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            dataAdapter.SelectCommand = cmd2;
            dataAdapter.Fill(dT);
            if (dT.Rows.Count > 0)
            {
                messegeTxt = "this login already exists !";
                result = true;
            }
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM user WHERE  email = @uP", dB.GetConnection());
            cmd.Parameters.Add("@uP", MySqlDbType.VarChar).Value = email;
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dT);
            if (dT.Rows.Count > 0)
            {
                messegeTxt = "this email already exists !";
                result = true;
            }
            message = messegeTxt;
            return result;
                
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            Regex emailRegex = new Regex(@"^[\d|\w|\-\.]+@\w+\.[\w\.]+");
            Regex nameAndSurnameRegex = new Regex(@"^([А-Я]{1}[а-яё]{1,23}|[A-Z]{1}[a-z]{1,23})$");
            Regex loginRegex = new Regex(@"^\w{5,10}");

            //min 8cahrs min 1 letter in UpperCase min 1 number min 1 LowerCase
            Regex passwordRegex = new Regex(@"^(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$");
            string enteredLoginInfo = registerLoginTextBox.Text;
            string enteredPassInfo = passwordTextBox.Text;
            string confirmedPassInfo = confirmPasswordTextBox.Text;
            string enteredEmailInfo = emailTextBox.Text;
            string enteredNameInfo = FirstLetterToUpper( nameTextBox.Text);
            string enteredSurnameInfo = FirstLetterToUpper(surnameTextBox.Text);
            
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"INSERT INTO user(login,password,name,surname,email) VALUES(@Login,@Pass,@Name,@Surname,@Email)",db.GetConnection());
            command.Parameters.Add("@Login",MySqlDbType.VarChar).Value = enteredLoginInfo;
            command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = enteredPassInfo;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = enteredNameInfo;
            command.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = enteredSurnameInfo;
            command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = enteredEmailInfo;
            if (!nameAndSurnameRegex.IsMatch(enteredNameInfo))
            {
               if(enteredNameInfo.Length<2)
                {
                    MessageBox.Show("Name can't be shorter than 2 symbols! ");
                }
               else
                {
                    MessageBox.Show("Wrong name format");
                }
              
                enteredNameInfo = string.Empty;
            }
            if( !nameAndSurnameRegex.IsMatch(enteredSurnameInfo))
            {
                if (enteredSurnameInfo.Length < 2)
                {
                    MessageBox.Show("Surname can't be shorter than 2 symbols! ");
                }
                else
                {
                    MessageBox.Show("Wrong surname  format");
                }
                enteredSurnameInfo = string.Empty;
            }
            if ( !emailRegex.IsMatch(enteredEmailInfo) )
            {
                MessageBox.Show("Wrong email Format!");
                enteredEmailInfo =string.Empty;
            }
            if (!loginRegex.IsMatch(enteredLoginInfo))
            {
                MessageBox.Show("Login must contains at least 5 and max 10 symbols\n(letters and numbers are availiable)");
                enteredLoginInfo = string.Empty;
            }
            if (!passwordRegex.IsMatch(enteredPassInfo) || !passwordRegex.IsMatch(confirmedPassInfo))
            {
                MessageBox.Show(" Password must cosists:\nMin 8cahrs, min 1 letter in UpperCase, min 1 number, min 1 letter in LowerCase");
                enteredPassInfo = string.Empty;
                confirmedPassInfo = string.Empty;
                confirmPasswordTextBox.Text = String.Empty;
                passwordTextBox.Text = String.Empty;
            }
            if (enteredPassInfo != confirmedPassInfo)
            {
                MessageBox.Show("Passwords didn't match");
                enteredPassInfo = string.Empty;
                confirmedPassInfo = string.Empty;
                confirmPasswordTextBox.Text =String.Empty;
                passwordTextBox.Text = String.Empty;
            }
            if (enteredPassInfo == confirmedPassInfo &&
                !string.IsNullOrEmpty(confirmedPassInfo) &&
                 !string.IsNullOrEmpty(enteredEmailInfo) &&
                 !string.IsNullOrEmpty(enteredNameInfo) &&
                 !string.IsNullOrEmpty(enteredLoginInfo) &&
                 !string.IsNullOrEmpty(enteredSurnameInfo))
            {
                //realization of emailconfirmation
                if (IsUserExists(enteredLoginInfo, enteredEmailInfo, out string messageText))
                {
                    if (messageText != string.Empty)
                        MessageBox.Show(messageText);
                      return;

                }
                db.OpenConnection();
             
                if (command.ExecuteNonQuery() == 1)//выполняеться функция  добавления если нет то -1 если да то 1
                    MessageBox.Show("Account has being created");
                else
                    MessageBox.Show("Fail");
                db.CloseConnection();

                registerLoginTextBox.Text = "";
                passwordTextBox.Text = "";
                confirmPasswordTextBox.Text = "";
                emailTextBox.Text = "";
                nameTextBox.Text = "";
                surnameTextBox.Text = "";
            }
            else
            {
                registerLoginTextBox.Text = "";
                passwordTextBox.Text = "";
                confirmPasswordTextBox.Text = "";
                emailTextBox.Text = "";
                nameTextBox.Text = "";
                surnameTextBox.Text = "";
            }
           
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
