namespace WinBackgroundWorker
{
    partial class Form1
    {
        /// <summary>
        /// Обов'язкова змінна конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очищення всіх використовуваних ресурсів.
        /// </summary>
        /// <param name="disposing">істинно, якщо керований ресурс потрібно утилізувати; інакше хибно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, створений конструктором форм Windows

        /// <summary>
        /// Метод для створення компонентів форми.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 20);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Seconds to sleep";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 53);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Progress";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 19);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(79, 27);
            textBox1.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(120, 53);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(274, 31);
            progressBar1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(223, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 33);
            button1.TabIndex = 4;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(309, 16);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 33);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 147);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "WinBackgroundWorker";
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
