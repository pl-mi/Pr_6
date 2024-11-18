namespace WinAsyncDelegate
{
    partial class Form1
    {
        /// <summary>
        /// Обов'язкове поле конструктора
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очищення використовуваних ресурсів
        /// </summary>
        /// <param name="disposing">true, якщо керовані ресурси потрібно видалити; інакше — false</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, створений Конструктором Windows Form Designer

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(10, 13);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Second to sleep";
            // 
            // label2
            // 
            label2.Location = new Point(10, 40);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Progress";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(47, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(110, 40);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(240, 20);
            progressBar1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(218, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 4;
            button1.Text = "Start";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(299, 13);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(439, 170);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "WinAsyncDelegate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
