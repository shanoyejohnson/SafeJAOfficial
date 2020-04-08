namespace SafeJAOfficial
{
    partial class addCommentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCommentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCommunity = new System.Windows.Forms.TextBox();
            this.cboParish = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubComment = new System.Windows.Forms.Button();
            this.pictureBoxaddcom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxaddcom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Parish";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Community";
            // 
            // txtCommunity
            // 
            this.txtCommunity.Location = new System.Drawing.Point(310, 207);
            this.txtCommunity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCommunity.Name = "txtCommunity";
            this.txtCommunity.Size = new System.Drawing.Size(315, 22);
            this.txtCommunity.TabIndex = 2;
            // 
            // cboParish
            // 
            this.cboParish.FormattingEnabled = true;
            this.cboParish.Location = new System.Drawing.Point(310, 169);
            this.cboParish.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboParish.Name = "cboParish";
            this.cboParish.Size = new System.Drawing.Size(224, 22);
            this.cboParish.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Comment";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(310, 249);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(315, 124);
            this.txtComment.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(484, 400);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 25);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubComment
            // 
            this.btnSubComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubComment.Location = new System.Drawing.Point(287, 400);
            this.btnSubComment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubComment.Name = "btnSubComment";
            this.btnSubComment.Size = new System.Drawing.Size(145, 25);
            this.btnSubComment.TabIndex = 4;
            this.btnSubComment.Text = "Submit Comment";
            this.btnSubComment.UseVisualStyleBackColor = true;
            this.btnSubComment.Click += new System.EventHandler(this.btnSubComment_Click);
            // 
            // pictureBoxaddcom
            // 
            this.pictureBoxaddcom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxaddcom.Image")));
            this.pictureBoxaddcom.Location = new System.Drawing.Point(284, 0);
            this.pictureBoxaddcom.Name = "pictureBoxaddcom";
            this.pictureBoxaddcom.Size = new System.Drawing.Size(233, 141);
            this.pictureBoxaddcom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxaddcom.TabIndex = 11;
            this.pictureBoxaddcom.TabStop = false;
            // 
            // addCommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(795, 485);
            this.Controls.Add(this.pictureBoxaddcom);
            this.Controls.Add(this.btnSubComment);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cboParish);
            this.Controls.Add(this.txtCommunity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addCommentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAFE Ja New Comment";
            this.Load += new System.EventHandler(this.addCommentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxaddcom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCommunity;
        private System.Windows.Forms.ComboBox cboParish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubComment;
        private System.Windows.Forms.PictureBox pictureBoxaddcom;
    }
}