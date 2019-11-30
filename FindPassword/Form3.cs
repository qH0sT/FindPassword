using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FindPassword
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);
        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            new Form2().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        public void Find()
        {
            string temporary = File.ReadAllText("extract.bat");
            File.WriteAllText("temp.bat",temporary.Replace("DOSYAYOLU",Form2.yol));
            Process.Start("temp.bat");
            System.Threading.Thread.Sleep(1000);
            var c = Process.GetProcessesByName("steghide").FirstOrDefault();
            IntPtr h = c.MainWindowHandle;
            SetForegroundWindow(h);
            SendKeys.SendWait(Form2.siff);
            SendKeys.SendWait("\n");
            File.Delete("temp.bat");
            System.Threading.Thread.Sleep(1000);
            try
            {
                DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory);
                FileInfo[] fi = di.GetFiles("*.txt");
                textBox1.Text = File.ReadAllText(fi[0].FullName);
                File.Delete(fi[0].FullName);
            }
            catch (Exception) { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            new Form1().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            Find();
        }
    }
}
