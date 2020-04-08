using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeJAOfficial
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            txtregnumber.Focus();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtregnumber.Clear();
            txtpassword.Clear();
            txtregnumber.Focus();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var regnumber = txtregnumber.Text;
            var password = txtpassword.Text;

            // declare object of DB model
            var contx = new zosoEntities();

            //check if true value was returned fron the user check and grant access
            //If false, then continue to restrict access
            var user = contx.users.SingleOrDefault(q => q.regNumber == regnumber && q.password == password);

            if (user != null)
            {
                var parent = (safejaMain)MdiParent;
                parent.isLoggedIn = true;
                this.Close();

                if (Application.OpenForms["viewCommentsForm"] == null)
                {
                    viewCommentsForm view = new viewCommentsForm();
                    view.Show();
                }
                else
                {
                    Application.OpenForms["viewCommentsForm"].Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid Credentials. Please try again.");
                txtregnumber.Text = "";
                txtpassword.Text = "";
                txtregnumber.Focus();
            }

            
        }

        
    }
}
