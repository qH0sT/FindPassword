using System;
using System.Windows.Forms;

namespace FindPassword
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = yol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Close();
            Form1 f1 = new Form1();
            f1.Show();

            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            new Form3().Show();
        }
        public static string yol;
        private void button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Title = "Bir resim dosyası seçin";
                op.Filter = "Resim dosyaları|*.jpeg;*.jpg;*.png";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = op.FileName;
                    yol = op.FileName;
                  
                }
            }

        }
        public static string siff;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            siff = textBox2.Text;
        }
    }
}