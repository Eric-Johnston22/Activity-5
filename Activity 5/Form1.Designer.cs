namespace Activity_5
{
    partial class form_file_read_write
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
            this.btn_read = new System.Windows.Forms.Button();
            this.tbx_display_file = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(371, 173);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 0;
            this.btn_read.Text = "Read file";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // tbx_display_file
            // 
            this.tbx_display_file.Location = new System.Drawing.Point(180, 202);
            this.tbx_display_file.Multiline = true;
            this.tbx_display_file.Name = "tbx_display_file";
            this.tbx_display_file.Size = new System.Drawing.Size(454, 146);
            this.tbx_display_file.TabIndex = 1;
            // 
            // form_file_read_write
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_display_file);
            this.Controls.Add(this.btn_read);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "form_file_read_write";
            this.Text = "Read and write";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.TextBox tbx_display_file;
    }
}

