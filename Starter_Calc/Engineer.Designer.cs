namespace SimpleCalculator
{
    partial class Engineer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private new System.ComponentModel.IContainer components = null;

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
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnSqr = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnFact = new System.Windows.Forms.Button();
            this.btnRoot3 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnSqrt.ForeColor = System.Drawing.Color.Black;
            this.btnSqrt.Location = new System.Drawing.Point(12, 539);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(112, 74);
            this.btnSqrt.TabIndex = 23;
            this.btnSqrt.TabStop = false;
            this.btnSqrt.Text = "√x";
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnPower
            // 
            this.btnPower.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnPower.ForeColor = System.Drawing.Color.Black;
            this.btnPower.Location = new System.Drawing.Point(142, 539);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(112, 74);
            this.btnPower.TabIndex = 24;
            this.btnPower.TabStop = false;
            this.btnPower.Text = "N˟";
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnSqr
            // 
            this.btnSqr.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnSqr.ForeColor = System.Drawing.Color.Black;
            this.btnSqr.Location = new System.Drawing.Point(398, 539);
            this.btnSqr.Name = "btnSqr";
            this.btnSqr.Size = new System.Drawing.Size(112, 74);
            this.btnSqr.TabIndex = 26;
            this.btnSqr.TabStop = false;
            this.btnSqr.Text = "x²";
            this.btnSqr.Click += new System.EventHandler(this.btnSqr_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnReverse.ForeColor = System.Drawing.Color.Black;
            this.btnReverse.Location = new System.Drawing.Point(267, 539);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(112, 74);
            this.btnReverse.TabIndex = 25;
            this.btnReverse.TabStop = false;
            this.btnReverse.Text = "1/x";
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnFact
            // 
            this.btnFact.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnFact.ForeColor = System.Drawing.Color.Black;
            this.btnFact.Location = new System.Drawing.Point(12, 629);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(136, 74);
            this.btnFact.TabIndex = 27;
            this.btnFact.TabStop = false;
            this.btnFact.Text = "!x";
            this.btnFact.Click += new System.EventHandler(this.btnFact_Click);
            // 
            // btnRoot3
            // 
            this.btnRoot3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnRoot3.ForeColor = System.Drawing.Color.Black;
            this.btnRoot3.Location = new System.Drawing.Point(168, 629);
            this.btnRoot3.Name = "btnRoot3";
            this.btnRoot3.Size = new System.Drawing.Size(136, 74);
            this.btnRoot3.TabIndex = 28;
            this.btnRoot3.TabStop = false;
            this.btnRoot3.Text = "³√x";
            this.btnRoot3.Click += new System.EventHandler(this.btnRoot3_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(328, 629);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 74);
            this.button3.TabIndex = 29;
            this.button3.TabStop = false;
            this.button3.Text = "Square equation";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Engineer
            // 
            this.ClientSize = new System.Drawing.Size(520, 705);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRoot3);
            this.Controls.Add(this.btnFact);
            this.Controls.Add(this.btnSqr);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnSqrt);
            this.MaximumSize = new System.Drawing.Size(550, 780);
            this.Name = "Engineer";
            this.Controls.SetChildIndex(this.VersionInfo, 0);
            this.Controls.SetChildIndex(this.OutputDisplay, 0);
            this.Controls.SetChildIndex(this.KeyExit, 0);
            this.Controls.SetChildIndex(this.KeyClear, 0);
            this.Controls.SetChildIndex(this.KeyDate, 0);
            this.Controls.SetChildIndex(this.KeyEqual, 0);
            this.Controls.SetChildIndex(this.KeyPoint, 0);
            this.Controls.SetChildIndex(this.KeySign, 0);
            this.Controls.SetChildIndex(this.KeyDivide, 0);
            this.Controls.SetChildIndex(this.KeyMultiply, 0);
            this.Controls.SetChildIndex(this.KeyMinus, 0);
            this.Controls.SetChildIndex(this.KeyPlus, 0);
            this.Controls.SetChildIndex(this.KeyZero, 0);
            this.Controls.SetChildIndex(this.KeyNine, 0);
            this.Controls.SetChildIndex(this.KeyEight, 0);
            this.Controls.SetChildIndex(this.KeySeven, 0);
            this.Controls.SetChildIndex(this.KeySix, 0);
            this.Controls.SetChildIndex(this.KeyFive, 0);
            this.Controls.SetChildIndex(this.KeyFour, 0);
            this.Controls.SetChildIndex(this.KeyThree, 0);
            this.Controls.SetChildIndex(this.KeyTwo, 0);
            this.Controls.SetChildIndex(this.KeyOne, 0);
            this.Controls.SetChildIndex(this.btnSqrt, 0);
            this.Controls.SetChildIndex(this.btnPower, 0);
            this.Controls.SetChildIndex(this.btnReverse, 0);
            this.Controls.SetChildIndex(this.btnSqr, 0);
            this.Controls.SetChildIndex(this.btnFact, 0);
            this.Controls.SetChildIndex(this.btnRoot3, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnSqr;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnFact;
        private System.Windows.Forms.Button btnRoot3;
        private System.Windows.Forms.Button button3;
    }
}
