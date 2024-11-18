using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace WinBackgroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ϳ������ �� ��䳿 BackgroundWorker
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ������ �������, ���� �������� ���� �� �����
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                int seconds;
                if (int.TryParse(textBox1.Text, out seconds))
                {
                    progressBar1.Value = 0;
                    backgroundWorker1.RunWorkerAsync(seconds);
                }
                else
                {
                    MessageBox.Show("������ ��������� �����!");
                }
            }
            else
            {
                MessageBox.Show("���� �� ���� ���� ������!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ���������� �������
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int seconds = (int)e.Argument;
            for (int i = 1; i <= seconds; i++)
            {
                // �������� �� ����������
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                Thread.Sleep(1000); // �������� �� 1 �������
                backgroundWorker1.ReportProgress((i * 100) / seconds); // ��������� ��������
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("������ ���������!");
            }
            else
            {
                MessageBox.Show("������ ���������!");
            }
        }
    }
}





