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
    public partial class viewCommentsForm : Form
    {
        private zosoEntities contx;
        private int rowid;

        public viewCommentsForm()
        {
            InitializeComponent();
        }

        private void viewCommentsForm_Load(object sender, EventArgs e)
        {
            contx = new zosoEntities();

            try
            {   
                //Populate the roles Dropdown and get parishes
                var parish = contx.parish.ToList();

                //Populate The Grid View
                RefreshGridView();


                //manually set the text for the column headers.
                gvreports.Columns["parishName"].HeaderText = "Parish";
                gvreports.Columns["community"].HeaderText = "Community";
                gvreports.Columns["userReport"].HeaderText = "Report";
                gvreports.Columns["reportDate"].HeaderText = "Date Reported";
                

                //Hide columns that you do not want to display to users
                gvreports.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //refresh the datagrid
        void RefreshGridView()
        {
            var parent = (safejaMain)MdiParent;

            var reports = contx.report.Select(q => new
            {
                q.Id,
                q.parish.parishName,
                q.community,
                q.reportDate,
                q.userReport,
            }).ToList();
            gvreports.DataSource = reports;
            gvreports.Refresh();
        }

        private void gvreports_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var row = gvreports.SelectedRows[0];
                rowid = (int)row.Cells["Id"].Value;
                lblCommunity.Text = row.Cells["community"].Value.ToString();
                lblDateReported.Text = row.Cells["reportDate"].Value.ToString();
                txtReport.Text = row.Cells["userReport"].Value.ToString();

                var rowParish = row.Cells["parishName"].Value.ToString();
                var parish = contx.parish.FirstOrDefault(q => q.parishName == rowParish).Id;

                lblParish.Text = rowParish.ToString();

            }
            catch (Exception)
            {

            }
        }

        //get row id
        int GetSelectedRow()
        {
            int row = (int)gvreports.SelectedRows[0].Cells[0].Value;
            return row;
        }

        //get report by ID
        report GetReportByID(int Id)
        {
            var report = contx.report.Find(Id);
            return report;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var parent = (safejaMain)MdiParent;
            parent.isLoggedIn = false;
            //Application.OpenForms["safejaMain"].Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
