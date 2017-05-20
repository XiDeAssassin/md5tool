using md5tool;
using System.Drawing;
using System;
using System.Windows.Forms;
namespace md5console
{
    class Program
    {
        string newline = Environment.NewLine;

        static void Main(string[] args)
        {
            string filenameWithPath = "";
            if (args.GetLength(0) > 0)
            {
                filenameWithPath = args[0];
            }

            Vars.fileNamewithPath = filenameWithPath;

            Func obj = new Func();
            if (obj.IsAdmin())
            {
                obj.CreateRegKey();
                MessageBox.Show("Reg OK!");
            }
            else
            {

                
                Form1 form = new Form1();


                form.ShowDialog();






                /*System.Windows.Forms.DialogResult result;
                result = obj.ShowMessage(filenameWithPath);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                */
            }
        }
    }


}
