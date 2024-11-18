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
            InitializeComponent(); // Ініціалізація компонентів
        }

        // Метод для виконання довготривалої операції
        private async Task TimeConsumingMethodAsync(int seconds)
        {
            for (int j = 1; j <= seconds; j++)
            {
                if (Cancel)
                {
                    MessageBox.Show("Відмінено!");
                    Cancel = false;
                    return;
                }

                SetProgress((j * 100) / seconds);
                await Task.Delay(1000);  // Заміна Thread.Sleep на Task.Delay
            }
            MessageBox.Show("Готово!");
        }

        // Делегат для оновлення ProgressBar
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

        // Обробник події для кнопки "Start"
        private async void button1_Click(object sender, EventArgs e)
        {
            Cancel = false;
            int seconds = int.Parse(textBox1.Text);
            await TimeConsumingMethodAsync(seconds);
        }

        // Обробник події для кнопки "Cancel"
        private void button2_Click(object sender, EventArgs e)
        {
            Cancel = true;
        }

        // Обробник події KeyPress для textBox1 (вводити лише цифри)
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле повинно містити цифри");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
