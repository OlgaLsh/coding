namespace Zachet_1
{
    partial class DataReader
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FirstDate = new System.Windows.Forms.DateTimePicker();
            this.LastDate = new System.Windows.Forms.DateTimePicker();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбор периода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Начало периода:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Конец периода:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(153, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Запросить данные";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FirstDate
            // 
            this.FirstDate.Location = new System.Drawing.Point(134, 43);
            this.FirstDate.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.FirstDate.Name = "FirstDate";
            this.FirstDate.Size = new System.Drawing.Size(200, 22);
            this.FirstDate.TabIndex = 7;
            this.FirstDate.Value = new System.DateTime(2021, 2, 24, 18, 16, 46, 0);
            // 
            // LastDate
            // 
            this.LastDate.Location = new System.Drawing.Point(134, 81);
            this.LastDate.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.LastDate.Name = "LastDate";
            this.LastDate.Size = new System.Drawing.Size(200, 22);
            this.LastDate.TabIndex = 8;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=LAPTOP-ERGTETKJ\\SQLEXPRESS;Initial Catalog=AdventureWorks2017;Integra" +
    "ted Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(361, 12);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.Size = new System.Drawing.Size(427, 268);
            this.ResultsTextBox.TabIndex = 9;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT SalesOrderID, SalesOrderDetailID, ProductID, ModifiedDate, OrderQty, LineT" +
    "otal\r\nFROM     Sales.SalesOrderDetail\r\nWHERE  (ModifiedDate BETWEEN @FirstDate A" +
    "ND @LastDate)";
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FirstDate", System.Data.SqlDbType.DateTime, 8, "ModifiedDate"),
            new System.Data.SqlClient.SqlParameter("@LastDate", System.Data.SqlDbType.DateTime, 8, "ModifiedDate")});
            // 
            // DataReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.LastDate);
            this.Controls.Add(this.FirstDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DataReader";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker FirstDate;
        private System.Windows.Forms.DateTimePicker LastDate;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
    }
}

