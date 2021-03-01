namespace Zachet_3
{
    partial class TeacherForm
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
            this.TeacherdataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TeacherdataGridView
            // 
            this.TeacherdataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.TeacherdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherdataGridView.Location = new System.Drawing.Point(3, 3);
            this.TeacherdataGridView.Name = "TeacherdataGridView";
            this.TeacherdataGridView.RowTemplate.Height = 24;
            this.TeacherdataGridView.Size = new System.Drawing.Size(797, 328);
            this.TeacherdataGridView.TabIndex = 0;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonSaveChanges.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(15, 382);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(241, 33);
            this.buttonSaveChanges.TabIndex = 1;
            this.buttonSaveChanges.Text = "Сохранить";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonClose.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(519, 382);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(241, 33);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(122, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Внесите необходимые изменения в базу данных и нажмите \"Сохранить\"";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.TeacherdataGridView);
            this.Name = "TeacherForm";
            this.Text = "Преподаватель";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TeacherdataGridView;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
    }
}