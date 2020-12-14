namespace ITMOEx4
{
    partial class Form2
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
            this.textBoxF21 = new System.Windows.Forms.TextBox();
            this.textBoxF22 = new System.Windows.Forms.TextBox();
            this.textBoxF23 = new System.Windows.Forms.TextBox();
            this.buttonF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxF21
            // 
            this.textBoxF21.Location = new System.Drawing.Point(61, 49);
            this.textBoxF21.Name = "textBoxF21";
            this.textBoxF21.Size = new System.Drawing.Size(100, 22);
            this.textBoxF21.TabIndex = 0;
            // 
            // textBoxF22
            // 
            this.textBoxF22.Location = new System.Drawing.Point(61, 106);
            this.textBoxF22.Name = "textBoxF22";
            this.textBoxF22.Size = new System.Drawing.Size(100, 22);
            this.textBoxF22.TabIndex = 1;
            // 
            // textBoxF23
            // 
            this.textBoxF23.Location = new System.Drawing.Point(61, 169);
            this.textBoxF23.Name = "textBoxF23";
            this.textBoxF23.Size = new System.Drawing.Size(100, 22);
            this.textBoxF23.TabIndex = 2;
            // 
            // buttonF2
            // 
            this.buttonF2.Location = new System.Drawing.Point(61, 236);
            this.buttonF2.Name = "buttonF2";
            this.buttonF2.Size = new System.Drawing.Size(147, 32);
            this.buttonF2.TabIndex = 3;
            this.buttonF2.Text = "button1";
            this.buttonF2.UseVisualStyleBackColor = true;
            this.buttonF2.Click += new System.EventHandler(this.buttonF2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonF2);
            this.Controls.Add(this.textBoxF23);
            this.Controls.Add(this.textBoxF22);
            this.Controls.Add(this.textBoxF21);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxF21;
        private System.Windows.Forms.TextBox textBoxF22;
        private System.Windows.Forms.TextBox textBoxF23;
        private System.Windows.Forms.Button buttonF2;
    }
}