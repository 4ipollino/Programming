namespace Non_modalWindows
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxF23 = new System.Windows.Forms.TextBox();
            this.textBoxF22 = new System.Windows.Forms.TextBox();
            this.textBoxF21 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxF23
            // 
            this.textBoxF23.Location = new System.Drawing.Point(101, 166);
            this.textBoxF23.Name = "textBoxF23";
            this.textBoxF23.Size = new System.Drawing.Size(240, 31);
            this.textBoxF23.TabIndex = 1;
            // 
            // textBoxF22
            // 
            this.textBoxF22.Location = new System.Drawing.Point(101, 118);
            this.textBoxF22.Name = "textBoxF22";
            this.textBoxF22.Size = new System.Drawing.Size(240, 31);
            this.textBoxF22.TabIndex = 2;
            // 
            // textBoxF21
            // 
            this.textBoxF21.Location = new System.Drawing.Point(101, 72);
            this.textBoxF21.Name = "textBoxF21";
            this.textBoxF21.Size = new System.Drawing.Size(240, 31);
            this.textBoxF21.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 299);
            this.Controls.Add(this.textBoxF21);
            this.Controls.Add(this.textBoxF22);
            this.Controls.Add(this.textBoxF23);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxF23;
        private System.Windows.Forms.TextBox textBoxF22;
        private System.Windows.Forms.TextBox textBoxF21;
    }
}