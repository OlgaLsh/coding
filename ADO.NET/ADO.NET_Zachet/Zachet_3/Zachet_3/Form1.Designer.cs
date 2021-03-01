namespace Zachet_3
{
    partial class Question
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
            this.buttonTeacher = new System.Windows.Forms.Button();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTeacher
            // 
            this.buttonTeacher.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonTeacher.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTeacher.Location = new System.Drawing.Point(60, 50);
            this.buttonTeacher.Name = "buttonTeacher";
            this.buttonTeacher.Size = new System.Drawing.Size(166, 35);
            this.buttonTeacher.TabIndex = 0;
            this.buttonTeacher.Text = "Преподаватель";
            this.buttonTeacher.UseVisualStyleBackColor = false;
            this.buttonTeacher.Click += new System.EventHandler(this.buttonTeacher_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonStudent.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudent.Location = new System.Drawing.Point(60, 91);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(166, 35);
            this.buttonStudent.TabIndex = 1;
            this.buttonStudent.Text = "Студент";
            this.buttonStudent.UseVisualStyleBackColor = false;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кем вы являетесь?";
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(295, 149);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStudent);
            this.Controls.Add(this.buttonTeacher);
            this.Name = "Question";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTeacher;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Label label1;
    }
}

