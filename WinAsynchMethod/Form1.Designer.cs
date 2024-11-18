namespace WinAsyncMethod
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистка ресурсів
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, створений конструктором Windows Form Designer

        private void InitializeComponent()
        {
            btnRun = new Button();
            btnWork = new Button();
            lblA = new Label();
            lblB = new Label();
            txbA = new TextBox();
            txbB = new TextBox();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(16, 64);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(75, 34);
            btnRun.TabIndex = 0;
            btnRun.Text = "Сума";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnWork
            // 
            btnWork.Location = new Point(120, 128);
            btnWork.Name = "btnWork";
            btnWork.Size = new Size(75, 36);
            btnWork.TabIndex = 1;
            btnWork.Text = "Робота";
            btnWork.UseVisualStyleBackColor = true;
            btnWork.Click += btnWork_Click;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(8, 24);
            lblA.Name = "lblA";
            lblA.Size = new Size(93, 20);
            lblA.TabIndex = 2;
            lblA.Text = "Значення A:";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(216, 24);
            lblB.Name = "lblB";
            lblB.Size = new Size(92, 20);
            lblB.TabIndex = 3;
            lblB.Text = "Значення B:";
            // 
            // txbA
            // 
            txbA.Location = new Point(107, 24);
            txbA.Name = "txbA";
            txbA.Size = new Size(81, 27);
            txbA.TabIndex = 4;
            // 
            // txbB
            // 
            txbB.Location = new Point(314, 24);
            txbB.Name = "txbB";
            txbB.Size = new Size(100, 27);
            txbB.TabIndex = 5;
            txbB.TextChanged += txbB_TextChanged;
            // 
            // Form1
            // 
            ClientSize = new Size(425, 200);
            Controls.Add(txbB);
            Controls.Add(txbA);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(btnWork);
            Controls.Add(btnRun);
            Name = "Form1";
            Text = "Асинхронний запуск";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.TextBox txbB;
    }
}

