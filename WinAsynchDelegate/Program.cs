using System;
using System.Windows.Forms;

namespace WinAsyncDelegate
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // Викликаємо Form1
        }
    }
}


