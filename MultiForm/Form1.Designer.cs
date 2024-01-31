namespace MultiForm
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
            this.btnShowForm = new System.Windows.Forms.Button();
            this.txtShared = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShowForm
            // 
            this.btnShowForm.Location = new System.Drawing.Point(81, 38);
            this.btnShowForm.Name = "btnShowForm";
            this.btnShowForm.Size = new System.Drawing.Size(86, 32);
            this.btnShowForm.TabIndex = 0;
            this.btnShowForm.Text = "Show Form";
            this.btnShowForm.UseVisualStyleBackColor = true;
            this.btnShowForm.Click += new System.EventHandler(this.btnShowForm_Click);
            // 
            // txtShared
            // 
            this.txtShared.Location = new System.Drawing.Point(73, 98);
            this.txtShared.Name = "txtShared";
            this.txtShared.Size = new System.Drawing.Size(139, 20);
            this.txtShared.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 179);
            this.Controls.Add(this.txtShared);
            this.Controls.Add(this.btnShowForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowForm;
        public System.Windows.Forms.TextBox txtShared;
    }
}

