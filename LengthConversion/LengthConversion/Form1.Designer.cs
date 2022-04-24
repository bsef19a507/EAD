namespace LengthConversion
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
            this.heading = new System.Windows.Forms.Label();
            this.input_label = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.result_label = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.covert_btn = new System.Windows.Forms.Button();
            this.feet_convert_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.heading.Location = new System.Drawing.Point(336, 29);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(516, 32);
            this.heading.TabIndex = 0;
            this.heading.Text = "Default length calculationn is in Inches";
            this.heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input_label.Location = new System.Drawing.Point(292, 98);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(201, 18);
            this.input_label.TabIndex = 1;
            this.input_label.Text = "Enter Length (in Meters)";
            this.input_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.input_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(499, 98);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(266, 22);
            this.input.TabIndex = 2;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.result_label.Location = new System.Drawing.Point(434, 146);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(59, 18);
            this.result_label.TabIndex = 3;
            this.result_label.Text = "Result";
            this.result_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.result_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(499, 145);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(266, 22);
            this.result.TabIndex = 4;
            // 
            // covert_btn
            // 
            this.covert_btn.BackColor = System.Drawing.Color.DarkViolet;
            this.covert_btn.ForeColor = System.Drawing.Color.White;
            this.covert_btn.Location = new System.Drawing.Point(499, 197);
            this.covert_btn.Name = "covert_btn";
            this.covert_btn.Size = new System.Drawing.Size(266, 36);
            this.covert_btn.TabIndex = 5;
            this.covert_btn.Text = "CONVERT";
            this.covert_btn.UseVisualStyleBackColor = false;
            this.covert_btn.UseWaitCursor = true;
            this.covert_btn.Click += new System.EventHandler(this.covert_btn_Click);
            // 
            // feet_convert_btn
            // 
            this.feet_convert_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.feet_convert_btn.ForeColor = System.Drawing.Color.White;
            this.feet_convert_btn.Location = new System.Drawing.Point(499, 250);
            this.feet_convert_btn.Name = "feet_convert_btn";
            this.feet_convert_btn.Size = new System.Drawing.Size(266, 36);
            this.feet_convert_btn.TabIndex = 6;
            this.feet_convert_btn.Text = "CONVERT TO FEET";
            this.feet_convert_btn.UseVisualStyleBackColor = false;
            this.feet_convert_btn.UseWaitCursor = true;
            this.feet_convert_btn.Click += new System.EventHandler(this.feet_convert_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.feet_convert_btn);
            this.Controls.Add(this.covert_btn);
            this.Controls.Add(this.result);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.input);
            this.Controls.Add(this.input_label);
            this.Controls.Add(this.heading);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Length Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button covert_btn;
        private System.Windows.Forms.Button feet_convert_btn;
    }
}

