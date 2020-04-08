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
    public partial class addCommentForm : Form
    {
        private zosoEntities contx;

        public addCommentForm()
        {
            InitializeComponent();
        }

        private void addCommentForm_Load(object sender, EventArgs e)
        {
            try
            {
                contx = new zosoEntities();

                //populate the parish dropdown list
                var parish = contx.parish.ToList();
                cboParish.DataSource = parish;
                cboParish.DisplayMember = "parishName";
                cboParish.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSubComment_Click(object sender, EventArgs e)
        {
            var parent = (safejaMain)MdiParent;

            try
            {
                //collect data from the form
                var comm = txtCommunity.Text;
                var rep = txtComment.Text;
                var date = DateTime.Now;

                var parish = Convert.ToInt32(cboParish.SelectedValue);

                if (isFormInvalid())
                {
                    MessageBox.Show("Please validate all data before submission!");
                }
                else
                {
                    var newReport = new report
                    {
                        community = comm,
                        userReport = rep,
                        reportDate = date,
                        parishID = parish
                    };

                    contx.report.Add(newReport);
                    contx.SaveChanges();
                    MessageBox.Show("Comment Successfully Submitted!");

                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A fatal. {ex.Message}");
            }
        }

        void ResetForm()
        {
            txtComment.Clear();
            txtCommunity.Clear();
            cboParish.SelectedIndex = 0;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        bool isFormInvalid()
        {
            return String.IsNullOrEmpty(txtCommunity.Text) || String.IsNullOrEmpty(txtComment.Text);
        }
    }
}
