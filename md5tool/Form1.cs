using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                MessageBox.Show("MD5 is " + obj.MD5file(dialog.FileName) + Environment.NewLine + "SHA-1 is " + obj.SHA1file(dialog.FileName));
            }
        }
    }
}
