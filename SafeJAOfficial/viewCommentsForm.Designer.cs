namespace SafeJAOfficial
{
    partial class viewCommentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDateReported = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCommunity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblParish = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gvreports = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvreports)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDateReported);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtReport);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblCommunity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblParish);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(71, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 144);
            this.panel1.TabIndex = 0;
            // 
            // lblDateReported
            // 
            this.lblDateReported.AutoSize = true;
            this.lblDateReported.Location = new System.Drawing.Point(130, 98);
            this.lblDateReported.Name = "lblDateReported";
            this.lblDateReported.Size = new System.Drawing.Size(0, 14);
            this.lblDateReported.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date Reported:";
            // 
            // txtReport
            // 
            this.txtReport.BackColor = System.Drawing.Color.White;
            this.txtReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReport.Location = new System.Drawing.Point(362, 36);
            this.txtReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(484, 90);
            this.txtReport.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Report";
            // 
            // lblCommunity
            // 
            this.lblCommunity.AutoSize = true;
            this.lblCommunity.Location = new System.Drawing.Point(130, 66);
            this.lblCommunity.Name = "lblCommunity";
            this.lblCommunity.Size = new System.Drawing.Size(0, 14);
            this.lblCommunity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Community:";
            // 
            // lblParish
            // 
            this.lblParish.AutoSize = true;
            this.lblParish.Location = new System.Drawing.Point(130, 38);
            this.lblParish.Name = "lblParish";
            this.lblParish.Size = new System.Drawing.Size(0, 14);
            this.lblParish.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parish:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gvreports);
            this.panel2.Location = new System.Drawing.Point(16, 184);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 293);
            this.panel2.TabIndex = 1;
            // 
            // gvreports
            // 
            this.gvreports.AllowUserToAddRows = false;
            this.gvreports.AllowUserToDeleteRows = false;
            this.gvreports.BackgroundColor = System.Drawing.Color.White;
            this.gvreports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvreports.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvreports.Location = new System.Drawing.Point(0, 0);
            this.gvreports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvreports.Name = "gvreports";
            this.gvreports.ReadOnly = true;
            this.gvreports.Size = new System.Drawing.Size(886, 289);
            this.gvreports.TabIndex = 0;
            this.gvreports.SelectionChanged += new System.EventHandler(this.gvreports_SelectionChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(773, 489);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(99, 24);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // viewCommentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(915, 526);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewCommentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Safe Ja View Comments";
            this.Load += new System.EventHandler(this.viewCommentsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvreports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCommunity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblParish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvreports;
        private System.Windows.Forms.Label lblDateReported;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
    }
}