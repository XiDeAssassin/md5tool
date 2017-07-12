using System;
using System.Windows.Forms;

namespace md5tool
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }
        Func obj = new Func();
        string newline = Environment.NewLine;
        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.SpecialFolder.Desktop.ToString()
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Vars.fileNamewithPath = dialog.FileName;
                Result form2 = new Result();
                form2.Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!Func.IsAdmin())
            {
                Func.RunasAdmin(true);
            }

            else
            {
                Func.CreateRegKey();
                MessageBox.Show("Reg OK!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
