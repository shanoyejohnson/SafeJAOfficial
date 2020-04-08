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
    public partial class safejaMain : Form
    {
        public safejaMain()
        {
            InitializeComponent();
        }
        //check login status
        public bool isLoggedIn = false;

        private void safejaMain_Load(object sender, EventArgs e)
        {
            
        }

        //show login form
        private void showLoginForm()
        {
            if (Application.OpenForms["LoginForm"] == null)
            {
                LoginForm login = new LoginForm();
                login.MdiParent = this;
                login.Show();
            }


        }

        //logout user
        //public void Logout()
        //{
        //    isLoggedIn = false;
        //    if(ActiveMdiChild != null)
        //    {
        //        ActiveMdiChild.Close();
        //    }
        //}
        

        private void btnViewComments_Click(object sender, EventArgs e)
        {            
            if (isLoggedIn)
            {
                if (Application.OpenForms["viewCommentsForm"] == null)
                {
                    viewCommentsForm view = new viewCommentsForm();
                    view.MdiParent = this;
                    view.Show();
                }
                else
                {
                    Application.OpenForms["viewCommentsForm"].Focus();
                }
            }
            else
            {
                showLoginForm();
            }


        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["addCommentForm"] == null)
            {
                addCommentForm add = new addCommentForm();
                add.MdiParent = this;
                add.Show();
            }
            else
            {
                Application.OpenForms["addCommentForm"].Focus();
            }
        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }
    }
}
