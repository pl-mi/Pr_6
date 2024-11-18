using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAsyncMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Асинхронний метод для обчислення суми
        private async Task<int> SummAsync(int a, int b)
        {
            await Task.Delay(9000); // Емуляція затримки (9 секунд)
            return a + b;
        }

        // Обробник для кнопки "Сума"
        private async void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;

            try
            {
                // Перетворення тексту з текстових полів у числа
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При виконанні перетворення даних виникла помилка.");
                txbA.Text = txbB.Text = "";
                return;
            }

            // Асинхронний виклик методу SummAsync
            try
            {
                int result = await SummAsync(a, b);
                MessageBox.Show($"Сума введених чисел дорівнює {result}", "Результат операції");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}");
            }
        }

        // Обробник для кнопки "Робота"
        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Робота кипить!!!");
        }

        private void txbB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
