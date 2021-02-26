namespace CourseManager
{
    partial class CourseViewer
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
            this.departmentList = new System.Windows.Forms.ComboBox();
            this.closeForm = new System.Windows.Forms.Button();
            this.courseGridView = new System.Windows.Forms.DataGridView();
            this.saveChanges = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewOffices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentList
            // 
            this.departmentList.FormattingEnabled = true;
            this.departmentList.Location = new System.Drawing.Point(443, 30);
            this.departmentList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.departmentList.Name = "departmentList";
            this.departmentList.Size = new System.Drawing.Size(204, 24);
            this.departmentList.TabIndex = 0;
            this.departmentList.SelectedIndexChanged += new System.EventHandler(this.departmentList_SelectedIndexChanged);
            // 
            // closeForm
            // 
            this.closeForm.Location = new System.Drawing.Point(443, 135);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(126, 40);
            this.closeForm.TabIndex = 1;
            this.closeForm.Text = "Закрыть";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // courseGridView
            // 
            this.courseGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.courseGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.courseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGridView.Location = new System.Drawing.Point(13, 13);
            this.courseGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseGridView.Name = "courseGridView";
            this.courseGridView.Size = new System.Drawing.Size(372, 185);
            this.courseGridView.TabIndex = 2;
            this.courseGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseGridView_CellContentClick);
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(443, 87);
            this.saveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(126, 40);
            this.saveChanges.TabIndex = 3;
            this.saveChanges.Text = "Обновить";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 206);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 185);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // viewOffices
            // 
            this.viewOffices.AutoSize = true;
            this.viewOffices.Location = new System.Drawing.Point(443, 183);
            this.viewOffices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewOffices.Name = "viewOffices";
            this.viewOffices.Size = new System.Drawing.Size(126, 40);
            this.viewOffices.TabIndex = 5;
            this.viewOffices.Text = "View Offices";
            this.viewOffices.UseVisualStyleBackColor = true;
            this.viewOffices.Click += new System.EventHandler(this.viewOffices_Click);
            // 
            // CourseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 404);
            this.Controls.Add(this.viewOffices);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.courseGridView);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.departmentList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CourseViewer";
            this.Text = "Course Viewer";
            this.Load += new System.EventHandler(this.CourseViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox departmentList;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.DataGridView courseGridView;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewOffices;
    }
}

