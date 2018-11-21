namespace WindowsFormsApplication2
{
    partial class Form5
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
            this.sourcebox = new System.Windows.Forms.TextBox();
            this.destinationbox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourcebox
            // 
            this.sourcebox.Location = new System.Drawing.Point(159, 64);
            this.sourcebox.Name = "sourcebox";
            this.sourcebox.Size = new System.Drawing.Size(100, 22);
            this.sourcebox.TabIndex = 0;
            // 
            // destinationbox
            // 
            this.destinationbox.Location = new System.Drawing.Point(159, 129);
            this.destinationbox.Name = "destinationbox";
            this.destinationbox.Size = new System.Drawing.Size(100, 22);
            this.destinationbox.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(104, 202);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 319);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.destinationbox);
            this.Controls.Add(this.sourcebox);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourcebox;
        private System.Windows.Forms.TextBox destinationbox;
        private System.Windows.Forms.Button submit;
    }
}