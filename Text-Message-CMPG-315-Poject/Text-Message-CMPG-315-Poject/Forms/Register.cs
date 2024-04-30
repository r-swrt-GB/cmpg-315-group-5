using Google.Cloud.Firestore;
using System;
using System.Windows.Forms;
using Text_Message_CMPG_315_Poject.Classes;

namespace Text_Message_CMPG_315_Poject.Forms
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnNavigateToLogin_Click(object sender, EventArgs e)
        {
            navigateToLogin();
        }

        public void navigateToLogin()
        {
            frmLogin loginForm = new frmLogin();

            loginForm.Show();

            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string password = tbxPassword.Text.Trim();
            string confirmPassword = tbxPassword.Text.Trim();

            if (password == confirmPassword)
            {
                string email = tbxEmail.Text.Trim();

                if (email == null || password == null)
                {
                    MessageBox.Show("Please enter a valid email and password");

                    return;
                }

                registerUser(email, password);
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }

        public User createUserProfile(string email, string password)
        {
            return new User()
            {
                Email = email,
                Password = password,
            };
        }

        public void registerUser(string email, string password)
        {
            if (checkIfUserExist(email))
            {
                MessageBox.Show("This email is already associated with an account");
            }

            var database = FirestoreHelper.Database;
            var data = createUserProfile(email, password);

            DocumentReference documentReference = database.Collection("users").Document(data.Email);
            documentReference.SetAsync(data);
            MessageBox.Show("Registration successful!");
        }

        public bool checkIfUserExist(string email)
        {

            var database = FirestoreHelper.Database;

            DocumentReference documentReference = database.Collection("users").Document(email);
            User user = documentReference.GetSnapshotAsync().Result.ConvertTo<User>();

            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
