using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.Windows.Forms;


/* 
 * WHEN NEW LICENSE IS GENERATED:
 * Make a encrpypted GUI ID Registry of conatcinated string of Physcial address and volume number of a PC and Licnumber
 * Store the new date data in it.
 * Store licnumber in a hidden file in pc. 
 * 
 * DO THIS AT FIRST RUN:
 * Take first install date write it in registry and hidden file
 * Calculate expire date and write it in registry and hidden file
 * 
 * DO THIS AT EVERY RUN:
 * Store todays date every run.
 * Check todays date before storing it.
 * If todays date is less than date stored in it. (Stored date is last run date) then thorw error that date is incorrect.
 * If todays date is equal to expire date. Expire the software and make a hidden file and registry to flag it.
 * 
 */







namespace DemoApp
{
    public class License
    {
        public string EncryptData(string data)
        {
            if (data == null)
                throw new ArgumentNullException("data");

            //encrypt data
            var encryptdata = Encoding.Unicode.GetBytes(data);
            byte[] encrypted = ProtectedData.Protect(encryptdata, null, DataProtectionScope.CurrentUser);

            //return as base64 string
            return Convert.ToBase64String(encrypted);
        }

        public string DecryptData(string cipher)
        {
            if (cipher == null) throw new ArgumentNullException("cipher");

            //parse base64 string
            byte[] data = Convert.FromBase64String(cipher);

            //decrypt data
            byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
            return Encoding.Unicode.GetString(decrypted);
        }


        public int firstTimeAppOpen()
        {

            //Create Folder
            try
            {
                System.IO.Directory.CreateDirectory("C:\\Program Files(x86)\\Common Files\\Sys32");
            }
            catch 
            {
                MessageBox.Show("Read Write Access Error!");
                return 0;
            }

            RegistryKey regkey = Registry.CurrentUser;
            regkey = regkey.CreateSubKey("Software\\Rano\\SomeApp"); //path

            DateTime dt = DateTime.Now;
            string Date = dt.ToShortDateString(); // get only date not time

            string getDate = EncryptData(Date);

            File.WriteAllText("C:\\Program Files(x86)\\Common Files\\Sys32\\mfc100d.dll", getDate);

            regkey.SetValue("Install", getDate); //Value Name,Value Data
            regkey.SetValue("Use", getDate); //Value Name,Value Data

            return 1;
        }

        public void FrstRunCheck()
        {
            
        }
    }
}
