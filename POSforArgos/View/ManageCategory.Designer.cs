namespace POSforArgos.View
{
    partial class ManageCategory
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
            this.components = new System.ComponentModel.Container();
            this.tabViewCategory = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCategoryUpdate = new System.Windows.Forms.TextBox();
            this.btnViewCategory = new System.Windows.Forms.Button();
            this.dataGridCategory = new System.Windows.Forms.DataGridView();
            this.tabControlCategory = new System.Windows.Forms.TabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabViewCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).BeginInit();
            this.tabControlCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabViewCategory
            // 
            this.tabViewCategory.Controls.Add(this.pictureBox4);
            this.tabViewCategory.Controls.Add(this.pictureBox3);
            this.tabViewCategory.Controls.Add(this.pictureBox2);
            this.tabViewCategory.Controls.Add(this.pictureBox1);
            this.tabViewCategory.Controls.Add(this.btnBack);
            this.tabViewCategory.Controls.Add(this.btnAdd);
            this.tabViewCategory.Controls.Add(this.lblMessage);
            this.tabViewCategory.Controls.Add(this.btnDelete);
            this.tabViewCategory.Controls.Add(this.lblID);
            this.tabViewCategory.Controls.Add(this.btnUpdate);
            this.tabViewCategory.Controls.Add(this.txtCategoryUpdate);
            this.tabViewCategory.Controls.Add(this.btnViewCategory);
            this.tabViewCategory.Controls.Add(this.dataGridCategory);
            this.tabViewCategory.Location = new System.Drawing.Point(4, 22);
            this.tabViewCategory.Name = "tabViewCategory";
            this.tabViewCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewCategory.Size = new System.Drawing.Size(533, 367);
            this.tabViewCategory.TabIndex = 1;
            this.tabViewCategory.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::POSforArgos.Properties.Resources.Update;
            this.pictureBox4.Location = new System.Drawing.Point(360, 122);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::POSforArgos.Properties.Resources.Delete;
            this.pictureBox3.Location = new System.Drawing.Point(360, 168);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POSforArgos.Properties.Resources.Add;
            this.pictureBox2.Location = new System.Drawing.Point(360, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POSforArgos.Properties.Resources.View;
            this.pictureBox1.Location = new System.Drawing.Point(361, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(404, 242);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 54);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back to Main";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(405, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 42);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(29, 271);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(76, 25);
            this.lblMessage.TabIndex = 19;
            this.lblMessage.Text = "label2";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(404, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 42);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(7, 199);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 29);
            this.lblID.TabIndex = 17;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(404, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 42);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCategoryUpdate
            // 
            this.txtCategoryUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryUpdate.Location = new System.Drawing.Point(34, 197);
            this.txtCategoryUpdate.Name = "txtCategoryUpdate";
            this.txtCategoryUpdate.Size = new System.Drawing.Size(236, 31);
            this.txtCategoryUpdate.TabIndex = 15;
            // 
            // btnViewCategory
            // 
            this.btnViewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCategory.Location = new System.Drawing.Point(405, 28);
            this.btnViewCategory.Name = "btnViewCategory";
            this.btnViewCategory.Size = new System.Drawing.Size(115, 40);
            this.btnViewCategory.TabIndex = 14;
            this.btnViewCategory.Text = "Refresh";
            this.btnViewCategory.UseVisualStyleBackColor = true;
            this.btnViewCategory.Click += new System.EventHandler(this.btnViewCategory_Click);
            // 
            // dataGridCategory
            // 
            this.dataGridCategory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategory.Location = new System.Drawing.Point(34, 28);
            this.dataGridCategory.MultiSelect = false;
            this.dataGridCategory.Name = "dataGridCategory";
            this.dataGridCategory.Size = new System.Drawing.Size(323, 154);
            this.dataGridCategory.TabIndex = 0;
            this.dataGridCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCategory_CellClick);
            // 
            // tabControlCategory
            // 
            this.tabControlCategory.Controls.Add(this.tabViewCategory);
            this.tabControlCategory.Location = new System.Drawing.Point(-1, -23);
            this.tabControlCategory.Name = "tabControlCategory";
            this.tabControlCategory.SelectedIndex = 0;
            this.tabControlCategory.Size = new System.Drawing.Size(541, 393);
            this.tabControlCategory.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 364);
            this.Controls.Add(this.tabControlCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ManageCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Category";
            this.Load += new System.EventHandler(this.ManageCategory_Load);
            this.tabViewCategory.ResumeLayout(false);
            this.tabViewCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).EndInit();
            this.tabControlCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabViewCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCategoryUpdate;
        private System.Windows.Forms.Button btnViewCategory;
        private System.Windows.Forms.DataGridView dataGridCategory;
        private System.Windows.Forms.TabControl tabControlCategory;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}