
namespace ITMOLab7Ex5
{
    partial class Form1
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
            this.lblMax = new System.Windows.Forms.Label();
            this.MaxValue = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(50, 13);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(206, 17);
            this.lblMax.TabIndex = 0;
            this.lblMax.Text = "Задайте максимальное число";
            this.lblMax.Click += new System.EventHandler(this.lblMax_Click);
            // 
            // MaxValue
            // 
            this.MaxValue.Location = new System.Drawing.Point(53, 32);
            this.MaxValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.Size = new System.Drawing.Size(203, 22);
            this.MaxValue.TabIndex = 2;
            this.MaxValue.TextChanged += new System.EventHandler(this.MaxValue_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(256, 14);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Вычисление";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 121);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.MaxValue);
            this.Controls.Add(this.lblMax);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Алгоритм Эратосфена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox MaxValue;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
    }
}

