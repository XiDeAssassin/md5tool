using System;
using System.Windows.Forms;

namespace md5tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Func obj = new Func();

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.SpecialFolder.Desktop.ToString()
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filename = dialog.FileName;
                string newline = Environment.NewLine;
                MessageBox.Show(filename + newline + "MD5 is " + obj.MD5file(filename) + newline + "SHA-1 is " + obj.SHA1file(filename));
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!obj.IsAdmin())
            {
                obj.RunasAdmin();
            }

            else
            {
                obj.CreateRegKey();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Environment.OSVersion.ToString());
        }
    }
}
