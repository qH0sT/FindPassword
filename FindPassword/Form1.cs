using System;
using System.Windows.Forms;

namespace FindPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
            Form2 f2 = new Form2();
            f2.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ((Form3)Application.OpenForms["Form3"]).Close();
            }
            catch (Exception) { }
            try
            {
                ((Form2)Application.OpenForms["Form2"]).Close();
            }
            catch (Exception) { }
        }
    }
}
