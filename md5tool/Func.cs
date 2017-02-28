using System;
using System.IO;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Security.Principal;
using System.Diagnostics;

namespace md5tool
{
    public class Func
    {
        public string newline = Environment.NewLine;
        public string MD5file(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }

        public string SHA1file(string filename)
        {
            using (var sha1 = SHA1.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    return BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }

        public void CreateRegKey()
        {
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"*shell", true);
            if (key == null)
            {
                key = Registry.ClassesRoot.CreateSubKey(@"*\shell");
            }
            RegistryKey custom = key.CreateSubKey("MD5 Tool");
            RegistryKey cmd = custom.CreateSubKey("command");
            cmd.SetValue("", Application.ExecutablePath + " %1");

            cmd.Close();
            custom.Close();
            key.Close();
        }

        public bool IsAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            bool isRunasAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if(isRunasAdmin == true)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void RunasAdmin()
        {
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                Verb = "runas",
                FileName = Application.StartupPath + @"\md5console.exe"
            };

            try
            {
                Process.Start(psi);
                Application.Exit();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DialogResult ShowMessage(string filename)
        {
            string message = filename + newline + "MD5 is " + MD5file(filename) + newline + "SHA-1 is " + SHA1file(filename);
            return MessageBox.Show(message,"MD5 result",MessageBoxButtons.OK);
        }
    }
}
