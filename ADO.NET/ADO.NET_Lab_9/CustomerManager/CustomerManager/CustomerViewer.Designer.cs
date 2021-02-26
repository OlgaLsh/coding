
namespace CustomerManager
{
    partial class CustomerViewer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridView = new System.Windows.Forms.DataGridView();
            this.labelid = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ViporderradioButton = new System.Windows.Forms.RadioButton();
            this.OrderradioButton = new System.Windows.Forms.RadioButton();
            this.CustomerradioButton = new System.Windows.Forms.RadioButton();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFile = new System.Windows.Forms.Button();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.textBoxmail = new System.Windows.Forms.TextBox();
            this.textBoxlastname = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderlistBox = new System.Windows.Forms.ListBox();
            this.customerList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridView.Location = new System.Drawing.Point(0, 220);
            this.GridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(1024, 334);
            this.GridView.TabIndex = 39;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(562, 184);
            this.labelid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(21, 17);
            this.labelid.TabIndex = 38;
            this.labelid.Text = "ID";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(591, 181);
            this.textBoxCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(420, 22);
            this.textBoxCustomer.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ViporderradioButton);
            this.groupBox1.Controls.Add(this.OrderradioButton);
            this.groupBox1.Controls.Add(this.CustomerradioButton);
            this.groupBox1.Location = new System.Drawing.Point(556, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(457, 58);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор данных";
            // 
            // ViporderradioButton
            // 
            this.ViporderradioButton.AutoSize = true;
            this.ViporderradioButton.Location = new System.Drawing.Point(325, 25);
            this.ViporderradioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViporderradioButton.Name = "ViporderradioButton";
            this.ViporderradioButton.Size = new System.Drawing.Size(94, 21);
            this.ViporderradioButton.TabIndex = 2;
            this.ViporderradioButton.TabStop = true;
            this.ViporderradioButton.Text = "Vip orders";
            this.ViporderradioButton.UseVisualStyleBackColor = true;
            // 
            // OrderradioButton
            // 
            this.OrderradioButton.AutoSize = true;
            this.OrderradioButton.Location = new System.Drawing.Point(227, 25);
            this.OrderradioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderradioButton.Name = "OrderradioButton";
            this.OrderradioButton.Size = new System.Drawing.Size(73, 21);
            this.OrderradioButton.TabIndex = 1;
            this.OrderradioButton.TabStop = true;
            this.OrderradioButton.Text = "Orders";
            this.OrderradioButton.UseVisualStyleBackColor = true;
            // 
            // CustomerradioButton
            // 
            this.CustomerradioButton.AutoSize = true;
            this.CustomerradioButton.Location = new System.Drawing.Point(109, 25);
            this.CustomerradioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerradioButton.Name = "CustomerradioButton";
            this.CustomerradioButton.Size = new System.Drawing.Size(96, 21);
            this.CustomerradioButton.TabIndex = 0;
            this.CustomerradioButton.TabStop = true;
            this.CustomerradioButton.Text = "Customers";
            this.CustomerradioButton.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(843, 51);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(132, 28);
            this.buttonDel.TabIndex = 35;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(703, 18);
            this.buttonOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(132, 61);
            this.buttonOut.TabIndex = 34;
            this.buttonOut.Text = "Показать данные";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(843, 18);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(132, 28);
            this.buttonEdit.TabIndex = 33;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(563, 18);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 61);
            this.buttonAdd.TabIndex = 32;
            this.buttonAdd.Text = "Добавить данные";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Фото";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Фамилия";
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(335, 154);
            this.buttonFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(133, 50);
            this.buttonFile.TabIndex = 27;
            this.buttonFile.Text = "Выбрать файл";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // textBoxage
            // 
            this.textBoxage.Location = new System.Drawing.Point(335, 121);
            this.textBoxage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(132, 22);
            this.textBoxage.TabIndex = 26;
            // 
            // textBoxmail
            // 
            this.textBoxmail.Location = new System.Drawing.Point(335, 87);
            this.textBoxmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxmail.Name = "textBoxmail";
            this.textBoxmail.Size = new System.Drawing.Size(132, 22);
            this.textBoxmail.TabIndex = 25;
            // 
            // textBoxlastname
            // 
            this.textBoxlastname.Location = new System.Drawing.Point(335, 54);
            this.textBoxlastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxlastname.Name = "textBoxlastname";
            this.textBoxlastname.Size = new System.Drawing.Size(132, 22);
            this.textBoxlastname.TabIndex = 24;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(335, 21);
            this.textBoxname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(132, 22);
            this.textBoxname.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Имя";
            // 
            // orderlistBox
            // 
            this.orderlistBox.FormattingEnabled = true;
            this.orderlistBox.ItemHeight = 16;
            this.orderlistBox.Location = new System.Drawing.Point(17, 55);
            this.orderlistBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderlistBox.Name = "orderlistBox";
            this.orderlistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.orderlistBox.Size = new System.Drawing.Size(209, 148);
            this.orderlistBox.TabIndex = 21;
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.Location = new System.Drawing.Point(17, 21);
            this.customerList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(211, 24);
            this.customerList.TabIndex = 20;
            // 
            // CustomerViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 554);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.textBoxage);
            this.Controls.Add(this.textBoxmail);
            this.Controls.Add(this.textBoxlastname);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderlistBox);
            this.Controls.Add(this.customerList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerViewer";
            this.Text = "Customer Viewer";
            this.Load += new System.EventHandler(this.CustomerViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OrderradioButton;
        private System.Windows.Forms.RadioButton CustomerradioButton;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.TextBox textBoxmail;
        private System.Windows.Forms.TextBox textBoxlastname;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox orderlistBox;
        private System.Windows.Forms.ComboBox customerList;
        private System.Windows.Forms.RadioButton ViporderradioButton;
    }
}

