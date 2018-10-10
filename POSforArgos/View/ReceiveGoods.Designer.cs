namespace POSforArgos.View
{
    partial class ReceiveGoods
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReceiveItem = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridItems = new System.Windows.Forms.DataGridView();
            this.cmbItemCode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddStockNow = new System.Windows.Forms.Button();
            this.dtPickerReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReceivedQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabViewItem = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            this.btnFilterByInvoice = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.dataGRNNotes = new System.Windows.Forms.DataGridView();
            this.myPosDbDataSet = new POSforArgos.View.myPosDbDataSet();
            this.itemStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.item_StockTableAdapter = new POSforArgos.View.myPosDbDataSetTableAdapters.Item_StockTableAdapter();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabReceiveItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).BeginInit();
            this.tabViewItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGRNNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPosDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabReceiveItem);
            this.tabControl1.Controls.Add(this.tabViewItem);
            this.tabControl1.Location = new System.Drawing.Point(6, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1277, 385);
            this.tabControl1.TabIndex = 0;
            // 
            // tabReceiveItem
            // 
            this.tabReceiveItem.Controls.Add(this.pictureBox2);
            this.tabReceiveItem.Controls.Add(this.txtInvoiceNumber);
            this.tabReceiveItem.Controls.Add(this.label2);
            this.tabReceiveItem.Controls.Add(this.dataGridItems);
            this.tabReceiveItem.Controls.Add(this.cmbItemCode);
            this.tabReceiveItem.Controls.Add(this.label7);
            this.tabReceiveItem.Controls.Add(this.btnAddStockNow);
            this.tabReceiveItem.Controls.Add(this.dtPickerReceivedDate);
            this.tabReceiveItem.Controls.Add(this.label6);
            this.tabReceiveItem.Controls.Add(this.txtReceivedQty);
            this.tabReceiveItem.Controls.Add(this.label3);
            this.tabReceiveItem.Controls.Add(this.label1);
            this.tabReceiveItem.Location = new System.Drawing.Point(4, 22);
            this.tabReceiveItem.Name = "tabReceiveItem";
            this.tabReceiveItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceiveItem.Size = new System.Drawing.Size(1269, 359);
            this.tabReceiveItem.TabIndex = 0;
            this.tabReceiveItem.Text = "Receive Items";
            this.tabReceiveItem.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POSforArgos.Properties.Resources.Add;
            this.pictureBox2.Location = new System.Drawing.Point(181, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNumber.Location = new System.Drawing.Point(228, 51);
            this.txtInvoiceNumber.MaxLength = 20;
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(238, 31);
            this.txtInvoiceNumber.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Invoice Number";
            // 
            // dataGridItems
            // 
            this.dataGridItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItems.Location = new System.Drawing.Point(485, 6);
            this.dataGridItems.Name = "dataGridItems";
            this.dataGridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridItems.Size = new System.Drawing.Size(505, 270);
            this.dataGridItems.TabIndex = 16;
            // 
            // cmbItemCode
            // 
            this.cmbItemCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbItemCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemCode.BackColor = System.Drawing.Color.White;
            this.cmbItemCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemCode.FormattingEnabled = true;
            this.cmbItemCode.Location = new System.Drawing.Point(228, 98);
            this.cmbItemCode.Name = "cmbItemCode";
            this.cmbItemCode.Size = new System.Drawing.Size(238, 32);
            this.cmbItemCode.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(163, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 33);
            this.label7.TabIndex = 14;
            this.label7.Text = "Good Received Note";
            // 
            // btnAddStockNow
            // 
            this.btnAddStockNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStockNow.Location = new System.Drawing.Point(228, 238);
            this.btnAddStockNow.Name = "btnAddStockNow";
            this.btnAddStockNow.Size = new System.Drawing.Size(238, 40);
            this.btnAddStockNow.TabIndex = 12;
            this.btnAddStockNow.Text = "Add to Receive";
            this.btnAddStockNow.UseVisualStyleBackColor = true;
            this.btnAddStockNow.Click += new System.EventHandler(this.btnAddStockNow_Click);
            // 
            // dtPickerReceivedDate
            // 
            this.dtPickerReceivedDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerReceivedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerReceivedDate.Location = new System.Drawing.Point(228, 188);
            this.dtPickerReceivedDate.Name = "dtPickerReceivedDate";
            this.dtPickerReceivedDate.Size = new System.Drawing.Size(238, 26);
            this.dtPickerReceivedDate.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Received Date";
            // 
            // txtReceivedQty
            // 
            this.txtReceivedQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceivedQty.Location = new System.Drawing.Point(228, 141);
            this.txtReceivedQty.MaxLength = 10;
            this.txtReceivedQty.Name = "txtReceivedQty";
            this.txtReceivedQty.Size = new System.Drawing.Size(238, 31);
            this.txtReceivedQty.TabIndex = 7;
            this.txtReceivedQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReceivedQty_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Received Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code";
            // 
            // tabViewItem
            // 
            this.tabViewItem.Controls.Add(this.pictureBox1);
            this.tabViewItem.Controls.Add(this.btn);
            this.tabViewItem.Controls.Add(this.btnFilterByInvoice);
            this.tabViewItem.Controls.Add(this.label4);
            this.tabViewItem.Controls.Add(this.txtInvoiceNo);
            this.tabViewItem.Controls.Add(this.dataGRNNotes);
            this.tabViewItem.Location = new System.Drawing.Point(4, 22);
            this.tabViewItem.Name = "tabViewItem";
            this.tabViewItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewItem.Size = new System.Drawing.Size(1269, 359);
            this.tabViewItem.TabIndex = 1;
            this.tabViewItem.Text = "View Items";
            this.tabViewItem.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POSforArgos.Properties.Resources.View;
            this.pictureBox1.Location = new System.Drawing.Point(327, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(256, 13);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(65, 23);
            this.btn.TabIndex = 4;
            this.btn.Text = "Refresh";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnFilterByInvoice
            // 
            this.btnFilterByInvoice.Location = new System.Drawing.Point(186, 13);
            this.btnFilterByInvoice.Name = "btnFilterByInvoice";
            this.btnFilterByInvoice.Size = new System.Drawing.Size(64, 23);
            this.btnFilterByInvoice.TabIndex = 3;
            this.btnFilterByInvoice.Text = "Filter";
            this.btnFilterByInvoice.UseVisualStyleBackColor = true;
            this.btnFilterByInvoice.Click += new System.EventHandler(this.btnFilterByInvoice_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Invoice No";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(67, 15);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(113, 20);
            this.txtInvoiceNo.TabIndex = 1;
            this.txtInvoiceNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInvoiceNo_KeyDown);
            this.txtInvoiceNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInvoiceNo_KeyUp);
            // 
            // dataGRNNotes
            // 
            this.dataGRNNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGRNNotes.Location = new System.Drawing.Point(6, 44);
            this.dataGRNNotes.Name = "dataGRNNotes";
            this.dataGRNNotes.Size = new System.Drawing.Size(1260, 350);
            this.dataGRNNotes.TabIndex = 0;
            // 
            // myPosDbDataSet
            // 
            this.myPosDbDataSet.DataSetName = "myPosDbDataSet";
            this.myPosDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemStockBindingSource
            // 
            this.itemStockBindingSource.DataMember = "Item_Stock";
            this.itemStockBindingSource.DataSource = this.myPosDbDataSet;
            // 
            // item_StockTableAdapter
            // 
            this.item_StockTableAdapter.ClearBeforeFill = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(12, 395);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(830, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 38);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back to Main";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ReceiveGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1295, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReceiveGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receive Goods";
            this.Load += new System.EventHandler(this.ReceiveGoods_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabReceiveItem.ResumeLayout(false);
            this.tabReceiveItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).EndInit();
            this.tabViewItem.ResumeLayout(false);
            this.tabViewItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGRNNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPosDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReceiveItem;
        private System.Windows.Forms.TabPage tabViewItem;
        private System.Windows.Forms.DateTimePicker dtPickerReceivedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReceivedQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStockNow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbItemCode;
        private myPosDbDataSet myPosDbDataSet;
        private System.Windows.Forms.BindingSource itemStockBindingSource;
        private myPosDbDataSetTableAdapters.Item_StockTableAdapter item_StockTableAdapter;
        private System.Windows.Forms.DataGridView dataGridItems;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGRNNotes;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnFilterByInvoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}