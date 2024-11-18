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

        // ����������� ����� ��� ���������� ����
        private async Task<int> SummAsync(int a, int b)
        {
            await Task.Delay(9000); // �������� �������� (9 ������)
            return a + b;
        }

        // �������� ��� ������ "����"
        private async void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;

            try
            {
                // ������������ ������ � ��������� ���� � �����
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("��� �������� ������������ ����� ������� �������.");
                txbA.Text = txbB.Text = "";
                return;
            }

            // ����������� ������ ������ SummAsync
            try
            {
                int result = await SummAsync(a, b);
                MessageBox.Show($"���� �������� ����� ������� {result}", "��������� ��������");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� �������: {ex.Message}");
            }
        }

        // �������� ��� ������ "������"
        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ ������!!!");
        }

        private void txbB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
