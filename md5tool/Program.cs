using System;
using System.Windows.Forms;

namespace md5tool
{
    public class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.GetLength(0) > 0)
            {
                Vars.fileNamewithPath = args[0];

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Result());
            }

            else
            {
                if (Func.IsAdmin())
                {
                    Func.CreateRegKey();
                    MessageBox.Show("Reg OK!");

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainView());

                }

                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainView());
                }
                
            }
        }

    }
}
