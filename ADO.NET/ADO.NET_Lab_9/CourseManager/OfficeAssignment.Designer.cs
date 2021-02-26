
namespace CourseManager
{
    partial class OfficeAssignment
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
            this.officeGridView = new System.Windows.Forms.DataGridView();
            this.saveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.officeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // officeGridView
            // 
            this.officeGridView.AllowUserToAddRows = false;
            this.officeGridView.AllowUserToDeleteRows = false;
            this.officeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officeGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeGridView.Location = new System.Drawing.Point(0, 49);
            this.officeGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.officeGridView.Name = "officeGridView";
            this.officeGridView.Size = new System.Drawing.Size(473, 293);
            this.officeGridView.TabIndex = 0;
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(114, 13);
            this.saveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(202, 28);
            this.saveChanges.TabIndex = 1;
            this.saveChanges.Text = "Update";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // OfficeAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 342);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.officeGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OfficeAssignment";
            this.Text = "Office Assignment";
            this.Load += new System.EventHandler(this.OfficeAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView officeGridView;
        private System.Windows.Forms.Button saveChanges;
    }
}