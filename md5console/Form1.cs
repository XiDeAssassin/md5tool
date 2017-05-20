using System;
using System.Windows.Forms;

namespace md5console
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            md5tool.Func obj = new md5tool.Func();
            label3.Text = obj.MD5file(Vars.fileNamewithPath);
            label4.Text = obj.SHA1file(Vars.fileNamewithPath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CopyButton(label3.Text);
        }

        private void CopyButton(string text)
        {
            Clipboard.SetData(DataFormats.UnicodeText, (string)text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CopyButton(label4.Text);
        }
    }
}
