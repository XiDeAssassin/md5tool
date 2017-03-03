using md5tool;
using System;
using System.Windows.Forms;
namespace md5console
{
    class Program
    {
        string newline = Environment.NewLine;

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
                string filename = "";
                if (args.GetLength(0) > 0)
                {
                    filename = args[0];
                }

                System.Windows.Forms.DialogResult result;
                result = obj.ShowMessage(filename);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    Environment.Exit(0);
                }


            }
            
        }


    }
}
