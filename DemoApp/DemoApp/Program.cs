using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32; // needed for registry access

namespace DemoApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        public static string expiredate = "";
        
        [STAThread]

        static void Main()
        {
            int period = 1; // trial period
            string keyName = "Software\\GUID\\374DE290-123F-4565-9164-39C4925E467B";
            long ticks = DateTime.Today.Ticks;
            bool expired = false;

            RegistryKey rootKey = Registry.CurrentUser;
            RegistryKey regKey = rootKey.OpenSubKey(keyName);
            if (regKey == null) // first time app has been used
            {

                DialogResult dialogResult = MessageBox.Show("Your software is not registered or expired. Do you want to register?", "License Manager", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Application.StartupPath + "\\License Manager.exe");
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

               

                /* regKey = rootKey.CreateSubKey(keyName);
                 long expiry = DateTime.Today.AddDays(period).Ticks;
                 regKey.SetValue("EGUID", expiry, RegistryValueKind.QWord);
                 regKey.Close();*/
            }
            else
            {
                long expiry = (long)regKey.GetValue("EGUID");
                long todayticks = (long)regKey.GetValue("TGUID");
                regKey.Close();
                long today = DateTime.Today.Ticks;

                DateTime myDate = new DateTime(expiry);
                expiredate = myDate.ToString("MMMM dd, yyyy");


                if (today < todayticks)
                {
                    MessageBox.Show("Date Time is incorrect of your System. Please reset the correct time.");
                    return;
                }
                if (today > expiry)
                {
                    MessageBox.Show("Your free trial has expired. Please register to continue using the application");
                    regKey = rootKey.OpenSubKey(keyName, true);
                    try
                    {
                        // regKey.DeleteSubKeyTree("GUID");
                        rootKey.DeleteSubKeyTree("Software\\GUID\\");
                    }
                    catch {
                        MessageBox.Show("Access Error");
                    }
                    expired = true;
                    return;
                }

                if (expired == false)
                {
                    regKey = rootKey.OpenSubKey(keyName, true);
                    todayticks = DateTime.Today.Ticks;
                    regKey.SetValue("TGUID", todayticks, RegistryValueKind.QWord);
                    regKey.Close();
                }

            }
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}




