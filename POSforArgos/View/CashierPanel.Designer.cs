namespace POSforArgos
{
    partial class CashierPanel
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
            this.btnManageCutomers = new System.Windows.Forms.Button();
            this.btnManageSales = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblCashierName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManageCutomers
            // 
            this.btnManageCutomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCutomers.Location = new System.Drawing.Point(5, 5);
            this.btnManageCutomers.Name = "btnManageCutomers";
            this.btnManageCutomers.Size = new System.Drawing.Size(276, 132);
            this.btnManageCutomers.TabIndex = 1;
            this.btnManageCutomers.Text = "Manage Customers";
            this.btnManageCutomers.UseVisualStyleBackColor = true;
            this.btnManageCutomers.Click += new System.EventHandler(this.btnManageCutomers_Click);
            // 
            // btnManageSales
            // 
            this.btnManageSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSales.Location = new System.Drawing.Point(287, 5);
            this.btnManageSales.Name = "btnManageSales";
            this.btnManageSales.Size = new System.Drawing.Size(276, 132);
            this.btnManageSales.TabIndex = 4;
            this.btnManageSales.Text = "Manage Sales";
            this.btnManageSales.UseVisualStyleBackColor = true;
            this.btnManageSales.Click += new System.EventHandler(this.btnManageSales_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(156, 168);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(257, 95);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout && Exit";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblCashierName
            // 
            this.lblCashierName.AutoSize = true;
            this.lblCashierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierName.Location = new System.Drawing.Point(261, 280);
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.Size = new System.Drawing.Size(0, 24);
            this.lblCashierName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Logged by :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POSforArgos.Properties.Resources.log_out;
            this.pictureBox1.Location = new System.Drawing.Point(418, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CashierPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 347);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCashierName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageSales);
            this.Controls.Add(this.btnManageCutomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CashierPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier\'s Panel";
            this.Load += new System.EventHandler(this.CashierPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageCutomers;
        private System.Windows.Forms.Button btnManageSales;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblCashierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}