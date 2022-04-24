namespace WindowsFormsApp2
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
            this.btn_show = new System.Windows.Forms.Button();
            this.lstBOX_show = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(172, 150);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 0;
            this.btn_show.Text = "Output";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // lstBOX_show
            // 
            this.lstBOX_show.FormattingEnabled = true;
            this.lstBOX_show.Location = new System.Drawing.Point(118, 28);
            this.lstBOX_show.Name = "lstBOX_show";
            this.lstBOX_show.Size = new System.Drawing.Size(120, 95);
            this.lstBOX_show.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 241);
            this.Controls.Add(this.lstBOX_show);
            this.Controls.Add(this.btn_show);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.ListBox lstBOX_show;
    }
}

