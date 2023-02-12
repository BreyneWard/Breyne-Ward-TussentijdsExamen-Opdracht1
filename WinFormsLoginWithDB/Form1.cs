using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace WinFormsLoginWithDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
        }

        private bool isFilledIn()
        {
            if(txt_username.Text.TrimStart() == string.Empty) 
            {
                MessageBox.Show("Enter valid username.","error");
                return false;
            }else if(txt_password.Text.TrimStart() == string.Empty) 
            {
                MessageBox.Show("Enter valid password.", "error");
                return false;
            }
            else
            { return true; }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(isFilledIn()) 
            {
                string validUser = "Paswoord";
                string validPassword = "Paswoord";
                if (txt_username.Text == validUser && txt_password.Text == validPassword)
                {
                    // MessageBox.Show("Succesfull login!");
                    MenuForm menuForm= new MenuForm();
                    this.Hide();
                    menuForm.Show();
                }
                else 
                {
                    if(MessageBox.Show("You need to enter a valid username and password", "error", MessageBoxButtons.OK)==DialogResult.OK)
                    {
                        Application.Exit();
                    }

                }
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}