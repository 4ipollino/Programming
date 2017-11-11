namespace CustomerManager
{
    partial class Form1
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
            this.customerList = new System.Windows.Forms.ComboBox();
            this.orderlistBox = new System.Windows.Forms.ListBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxlastname = new System.Windows.Forms.TextBox();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.textBoxmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrderradioButton = new System.Windows.Forms.RadioButton();
            this.CustomerradioButton = new System.Windows.Forms.RadioButton();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.diag = new System.Windows.Forms.OpenFileDialog();
            this.ViporderradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.Location = new System.Drawing.Point(28, 25);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(267, 33);
            this.customerList.TabIndex = 0;
            // 
            // orderlistBox
            // 
            this.orderlistBox.FormattingEnabled = true;
            this.orderlistBox.ItemHeight = 25;
            this.orderlistBox.Location = new System.Drawing.Point(28, 87);
            this.orderlistBox.Name = "orderlistBox";
            this.orderlistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.orderlistBox.Size = new System.Drawing.Size(267, 254);
            this.orderlistBox.TabIndex = 1;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(448, 22);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(256, 31);
            this.textBoxname.TabIndex = 2;
            // 
            // textBoxlastname
            // 
            this.textBoxlastname.Location = new System.Drawing.Point(448, 84);
            this.textBoxlastname.Name = "textBoxlastname";
            this.textBoxlastname.Size = new System.Drawing.Size(256, 31);
            this.textBoxlastname.TabIndex = 3;
            // 
            // textBoxage
            // 
            this.textBoxage.Location = new System.Drawing.Point(448, 206);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(256, 31);
            this.textBoxage.TabIndex = 5;
            // 
            // textBoxmail
            // 
            this.textBoxmail.Location = new System.Drawing.Point(448, 144);
            this.textBoxmail.Name = "textBoxmail";
            this.textBoxmail.Size = new System.Drawing.Size(256, 31);
            this.textBoxmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Возраст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Фото";
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(448, 266);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(256, 58);
            this.buttonFile.TabIndex = 11;
            this.buttonFile.Text = "Выберите файл...";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(780, 22);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(188, 93);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить данные";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(991, 22);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(188, 93);
            this.buttonOut.TabIndex = 13;
            this.buttonOut.Text = "Показать данные";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(1206, 22);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(188, 51);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(1206, 79);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(188, 36);
            this.buttonDel.TabIndex = 15;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ViporderradioButton);
            this.groupBox1.Controls.Add(this.OrderradioButton);
            this.groupBox1.Controls.Add(this.CustomerradioButton);
            this.groupBox1.Location = new System.Drawing.Point(780, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 84);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор данных";
            // 
            // OrderradioButton
            // 
            this.OrderradioButton.AutoSize = true;
            this.OrderradioButton.Location = new System.Drawing.Point(257, 40);
            this.OrderradioButton.Name = "OrderradioButton";
            this.OrderradioButton.Size = new System.Drawing.Size(108, 29);
            this.OrderradioButton.TabIndex = 1;
            this.OrderradioButton.TabStop = true;
            this.OrderradioButton.Text = "Orders";
            this.OrderradioButton.UseVisualStyleBackColor = true;
            // 
            // CustomerradioButton
            // 
            this.CustomerradioButton.AutoSize = true;
            this.CustomerradioButton.Checked = true;
            this.CustomerradioButton.Location = new System.Drawing.Point(76, 40);
            this.CustomerradioButton.Name = "CustomerradioButton";
            this.CustomerradioButton.Size = new System.Drawing.Size(146, 29);
            this.CustomerradioButton.TabIndex = 0;
            this.CustomerradioButton.TabStop = true;
            this.CustomerradioButton.Text = "Customers";
            this.CustomerradioButton.UseVisualStyleBackColor = true;
            this.CustomerradioButton.CheckedChanged += new System.EventHandler(this.CustomerradioButton_CheckedChanged);
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(935, 255);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(429, 31);
            this.textBoxCustomer.TabIndex = 17;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(792, 255);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(29, 25);
            this.labelid.TabIndex = 18;
            this.labelid.Text = "Id";
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridView.Location = new System.Drawing.Point(0, 413);
            this.GridView.Name = "GridView";
            this.GridView.RowTemplate.Height = 33;
            this.GridView.Size = new System.Drawing.Size(1426, 402);
            this.GridView.TabIndex = 19;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            // 
            // diag
            // 
            this.diag.DefaultExt = "*.jpg";
            this.diag.FileName = "openFileDialog1";
            this.diag.Filter = "JPG (*.jpg) | *.jpg";
            // 
            // ViporderradioButton
            // 
            this.ViporderradioButton.AutoSize = true;
            this.ViporderradioButton.Location = new System.Drawing.Point(409, 40);
            this.ViporderradioButton.Name = "ViporderradioButton";
            this.ViporderradioButton.Size = new System.Drawing.Size(145, 29);
            this.ViporderradioButton.TabIndex = 2;
            this.ViporderradioButton.TabStop = true;
            this.ViporderradioButton.Text = "Vip Orders";
            this.ViporderradioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1426, 815);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxage);
            this.Controls.Add(this.textBoxmail);
            this.Controls.Add(this.textBoxlastname);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.orderlistBox);
            this.Controls.Add(this.customerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerList;
        private System.Windows.Forms.ListBox orderlistBox;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxlastname;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.TextBox textBoxmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OrderradioButton;
        private System.Windows.Forms.RadioButton CustomerradioButton;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.OpenFileDialog diag;
        private System.Windows.Forms.RadioButton ViporderradioButton;
    }
}

