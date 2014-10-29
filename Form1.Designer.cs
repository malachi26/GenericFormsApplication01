namespace GenericFormsApplication01
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
            this.urlInput = new System.Windows.Forms.TextBox();
            this.urlInputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // urlInput
            // 
            this.urlInput.Location = new System.Drawing.Point(160, 34);
            this.urlInput.Name = "urlInput";
            this.urlInput.Size = new System.Drawing.Size(100, 20);
            this.urlInput.TabIndex = 0;
            // 
            // urlInputLabel
            // 
            this.urlInputLabel.AutoSize = true;
            this.urlInputLabel.Location = new System.Drawing.Point(13, 34);
            this.urlInputLabel.Name = "urlInputLabel";
            this.urlInputLabel.Size = new System.Drawing.Size(47, 13);
            this.urlInputLabel.TabIndex = 1;
            this.urlInputLabel.Text = "Input Url";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.urlInputLabel);
            this.Controls.Add(this.urlInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlInput;
        private System.Windows.Forms.Label urlInputLabel;
    }
}

