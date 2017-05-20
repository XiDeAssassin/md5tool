using md5tool;
using System.Drawing;
using System;
using System.Windows.Forms;
namespace md5console
{
    class Program
    {
        string newline = Environment.NewLine;
        [STAThread]
        static void Main(string[] args)
        {
            Func obj = new Func();

            if (obj.IsAdmin())
            {
                obj.CreateRegKey();
                MessageBox.Show("Reg OK!");
            }
            else
            {
                if (args.GetLength(0) > 0)
                {
                    Vars.fileNamewithPath = args[0];
                }

                Form2 form = new Form2();


                form.ShowDialog();

            }
        }
    }


}
