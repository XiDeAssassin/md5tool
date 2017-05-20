using System;
using System.Windows.Forms;

namespace md5tool
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            Func obj = new Func();
            label3.Text = obj.MD5file(Vars.fileNamewithPath);
            label4.Text = obj.SHA1file(Vars.fileNamewithPath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CopyButton(label3.Text);
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            CopyButton(label4.Text);
        }

        public void CopyButton(string input)
        {
            Clipboard.SetData(DataFormats.Text, (string)input);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Result.ActiveForm.Close();
        }


    }
}
