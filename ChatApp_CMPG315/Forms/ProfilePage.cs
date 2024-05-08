using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_CMPG315
{
    public partial class ProfilePage : Form
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        //to check if the values have changed
        string StartName, StartSurname, StartEmail, StartPassword;

        private void ProfilePage_Load(object sender, EventArgs e)
        {

            //sets start details for checking if details changed
            StartName = txtName.Texts = "Naam";
            StartSurname = txtSurname.Texts = "Van";
            StartEmail = txtEmail.Texts = "Emai@gmail.com";
            StartPassword = txtPassword.Texts = "password";
            txtPassword.PasswordChar = true;

            txtName.BorderColor = Color.Gray;
            txtSurname.BorderColor = Color.Gray;
            txtEmail.BorderColor = Color.Gray;
            txtPassword.BorderColor = Color.Gray;

            txtName.Enabled = false;
            txtSurname.Enabled = false;
            txtEmail.Enabled = false;
            txtPassword.Enabled = false;  
        }


        private bool fieldsChanged = false;

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChatForm chat = new ChatForm();
            this.Hide();
            chat.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            {
                // If fields have not been changed yet, change color and enable fields
                if (!fieldsChanged)
                {
                    txtName.BorderColor = Color.MediumSlateBlue;
                    txtSurname.BorderColor = Color.MediumSlateBlue;
                    txtEmail.BorderColor = Color.MediumSlateBlue;
                    txtPassword.BorderColor = Color.MediumSlateBlue;

                    txtName.Enabled = true;
                    txtSurname.Enabled = true;
                    txtEmail.Enabled = true;
                    txtPassword.Enabled = true;

                    fieldsChanged = true; // Set flag to true indicating fields have been changed
                }
                else
                {
                    // Check if fields have been changed from the beginning
                    bool fieldsChangedFromStart =
                        StartName != txtName.Texts ||
                        StartSurname != txtSurname.Texts ||
                        StartEmail != txtEmail.Texts ||
                        StartPassword != txtPassword.Texts;

                    // If fields have been changed from the beginning, ask for confirmation
                    if (fieldsChangedFromStart)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to update your account details?", "Confirmation", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            //tik in code of fucntion wat indformation update


                            MessageBox.Show("Update Successful!");

                            fieldsChanged = false;

                            txtName.BorderColor = Color.Gray;
                            txtSurname.BorderColor = Color.Gray;
                            txtEmail.BorderColor = Color.Gray;
                            txtPassword.BorderColor = Color.Gray;

                            txtName.Enabled = false;
                            txtSurname.Enabled = false;
                            txtEmail.Enabled = false;
                            txtPassword.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No changes made.");
                    }
                }
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to delete your account?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {


                MessageBox.Show("Account deletion successful!");
                this.Hide();
                Login login = new Login();
                login.Show();   

            }

        }

       

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == true)
            {
                txtPassword.PasswordChar = false;
            }
            else if (txtPassword.PasswordChar == false)
            {
                txtPassword.PasswordChar = true;
            }
        }
    }
}
