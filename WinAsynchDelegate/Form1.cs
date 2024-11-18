using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAsyncDelegate
{
    public partial class Form1 : Form
    {
        private bool Cancel = false;

        public Form1()
        {
            InitializeComponent(); // ����������� ����������
        }

        // ����� ��� ��������� ������������ ��������
        private async Task TimeConsumingMethodAsync(int seconds)
        {
            for (int j = 1; j <= seconds; j++)
            {
                if (Cancel)
                {
                    MessageBox.Show("³������!");
                    Cancel = false;
                    return;
                }

                SetProgress((j * 100) / seconds);
                await Task.Delay(1000);  // ����� Thread.Sleep �� Task.Delay
            }
            MessageBox.Show("������!");
        }

        // ������� ��� ��������� ProgressBar
        private delegate void SetProgressDelegate(int val);

        private void SetProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                SetProgressDelegate del = new SetProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value = val;
            }
        }

        // �������� ��䳿 ��� ������ "Start"
        private async void button1_Click(object sender, EventArgs e)
        {
            Cancel = false;
            int seconds = int.Parse(textBox1.Text);
            await TimeConsumingMethodAsync(seconds);
        }

        // �������� ��䳿 ��� ������ "Cancel"
        private void button2_Click(object sender, EventArgs e)
        {
            Cancel = true;
        }

        // �������� ��䳿 KeyPress ��� textBox1 (������� ���� �����)
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("���� ������� ������ �����");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
