using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;
using System.Management;
using Microsoft.Win32;

namespace License_Manager
{
    public partial class LicenseMgm : Form
    {
        public LicenseMgm()
        {
            InitializeComponent();

            CompanyName.Text = "Company name";
            ContactName.Text = "Vikram";
            EmailId.Text = "vikrambest1@gmail.com";
            PhoneNumber.Text = "9112324756";
            Address.Text = "Pune";
            City.Text = "Pune";
            State.Text = "MH";
            ZipCode.Text = "38";
            Country.Text = "Ind";
            numberofusers.Text = "1";
            ProductName.Text = "product1"; 
        }
        string global = "";

        private void RegLicButton_Click(object sender, EventArgs e)
        {
            bool textverifyflag = true;
            ErrorMsg.ForeColor = Color.Maroon;

            //********************************Data Verification*********************************************************
            
            if (CompanyName.Text == "")
            {
                ErrorMsg.Text="ERROR : Enter valid Company Name";
                textverifyflag = false;
                return;
            }//if
            else if(ContactName.Text == "")
            {
                ErrorMsg.Text = "ERROR : Enter valid Contact Name";
                textverifyflag = false;
                return;
            }
            if(EmailId.Text== "")
            {
                ErrorMsg.Text = "ERROR : Enter valid EmailId ";
                textverifyflag = false;
                return;
            }
            else
            {

                try
                {
                    var addr = new System.Net.Mail.MailAddress(EmailId.Text);
                    EmailId.Text=addr.Address;
                }
                catch
                {
                    ErrorMsg.Text = "ERROR : Enter valid EmailId";
                    textverifyflag = false;
                    return;
                }
            }
                if (PhoneNumber.Text.Length != 10 || (!PhoneNumber.Text.All(Char.IsDigit)) || PhoneNumber.Text == "")
                {

                 ErrorMsg.Text = "ERROR : Enter valid Contact Number";
                     textverifyflag = false;
                return;

            }
            
                if (Address.Text == "")
                {
                    ErrorMsg.Text = "ERROR : Enter valid address";
                    textverifyflag = false;
                    return;
                }
                if(State.Text == "")
                {
                    ErrorMsg.Text = "ERROR: Enter valid State";
                    textverifyflag = false;
                     return;
                }
                if (City.Text == "")
                {
                    ErrorMsg.Text = "ERROR : Enter valid city";
                    textverifyflag = false;
                    return;
                }
                if (ZipCode.Text == "")
                {
                    ErrorMsg.Text = "ERROR : Enter valid zipcode";
                    textverifyflag = false;
                   return;
                }
                if (Country.Text == "")
                {
                     ErrorMsg.Text = "ERROR : Enter valid country name";
                     textverifyflag = false;
                     return;
                }
                if (ProductName.Text == "" && ProductName.Text!="product1" && ProductName.Text!="product2")
                {
                    ErrorMsg.Text = "ERROR : Enter valid product name";
                    textverifyflag = false;
                   return;
                }
                 if (numberofusers.Text == "" || !numberofusers.Text.All(Char.IsDigit))
                {
                    ErrorMsg.Text = "ERROR : Enter valid user number";
                    textverifyflag = false;
                   return;
                 }
            //*********************************************************************************************

            //Writing Data in file in Registration.key 
            if (textverifyflag == true)
            {

                string mac = GetMacAddress();
                string SerialNumber = Identifier("Win32_DiskDrive", "SerialNumber");
                SerialNumber = SerialNumber.Replace(" ", "");
                string EncrptedID = Encryption(mac+SerialNumber);
                

                string[] lines =
                      {
                         "Company Name: "+CompanyName.Text,
                         "Contact Name: "+ContactName.Text,
                         "Email ID: "+EmailId.Text,
                         "Phone number: "+PhoneNumber.Text,
                         "Address: "+Address.Text,
                         "City: "+City.Text,
                         "State: "+State.Text,
                         "Zip Code: "+ZipCode.Text,
                         "Country: "+Country.Text,
                         "Number of Users: "+numberofusers.Text,
                         "Product Name: "+ProductName.Text,
                         "User Serial Number: "+EncrptedID
                       };
               
                File.WriteAllLinesAsync(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\Registration.key", lines);


                ErrorMsg.Text = "Succesful";
                ErrorMsg.ForeColor = Color.Green;
                MessageBox.Show("Sucessfully Registration Key created on your Desktop");

            }

        }

        private string GetMacAddress()
        {
            const int MIN_MAC_ADDR_LENGTH = 12;
            string macAddress = string.Empty;
            long maxSpeed = -1;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                string tempMac = nic.GetPhysicalAddress().ToString();
                if (nic.Speed > maxSpeed &&
                    !string.IsNullOrEmpty(tempMac) &&
                    tempMac.Length >= MIN_MAC_ADDR_LENGTH)
                {
                    //log.Debug("New Max Speed = " + nic.Speed + ", MAC: " + tempMac);
                    maxSpeed = nic.Speed;
                    macAddress = tempMac;
                }
            }

            return macAddress;
        }

        private string Identifier(string wmiClass, string wmiProperty)         //Return a hardware identifier
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                //Only get the first one
                if (result == "")
                {
                    try
                    {
                        result = mo[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
            }
            return result;
        }

        public string Encryption(string serialnumber)
        {
            string encypstr="";

            for (int i = 0; i < serialnumber.Length; i++)
            {
                if(serialnumber[i] == '1')
                {
                    encypstr += "AC";   
                }
                if (serialnumber[i] == '2')
                {
                    encypstr += "EF";
                }
                if (serialnumber[i] == '3')
                {
                    encypstr += "DT";
                }
                if (serialnumber[i] == '4')
                {
                    encypstr += "RG";
                }
                if (serialnumber[i] == '5')
                {
                    encypstr += "LK";
                }
                if (serialnumber[i] == '6')
                {
                    encypstr += "MN";
                }
                if (serialnumber[i] == '7')
                {
                    encypstr += "PO";
                }
                if (serialnumber[i] == '8')
                {
                    encypstr += "SZ";
                }
                if (serialnumber[i] == '9')
                {
                    encypstr += "UJ";
                }
                if (serialnumber[i] == '0')
                {
                    encypstr += "XW";
                }
                if (serialnumber[i] == 'A')
                {
                    encypstr += "47";
                }
                if (serialnumber[i] == 'B')
                {
                    encypstr += "52";
                }
                if (serialnumber[i] == 'C')
                {
                    encypstr += "61";
                }
                if (serialnumber[i] == 'D')
                {
                    encypstr += "23";
                }
                if (serialnumber[i] == 'E')
                {
                    encypstr += "98";
                }
                if (serialnumber[i] == 'F')
                {
                    encypstr += "13";
                }
                if (serialnumber[i] == 'G')
                {
                    encypstr += "08";
                }
                if (serialnumber[i] == 'H')
                {
                    encypstr += "77";
                }
                if (serialnumber[i] == 'I')
                {
                    encypstr += "36";
                }
                if (serialnumber[i] == 'J')
                {
                    encypstr += "81";
                }
                if (serialnumber[i] == 'K')
                {
                    encypstr += "42";
                }
                if (serialnumber[i] == 'L')
                {
                    encypstr += "55";
                }
                if (serialnumber[i] == 'M')
                {
                    encypstr += "67";
                }
                if (serialnumber[i] == 'N')
                {
                    encypstr += "29";
                }
                if (serialnumber[i] == 'O')
                {
                    encypstr += "91";
                }
                if (serialnumber[i] == 'P')
                {
                    encypstr += "17";
                }
                if (serialnumber[i] == 'Q')
                {
                    encypstr += "03";
                }
                if (serialnumber[i] == 'R')
                {
                    encypstr += "72";
                }
                if (serialnumber[i] == 'S')
                {
                    encypstr += "11";
                }
                if (serialnumber[i] == 'T')
                {
                    encypstr += "32";
                }
                if (serialnumber[i] == 'U')
                {
                    encypstr += "86";
                }
                if (serialnumber[i] == 'V')
                {
                    encypstr += "07";
                }
                if (serialnumber[i] == 'W')
                {
                    encypstr += "99";
                }
                if (serialnumber[i] == 'X')
                {
                    encypstr += "30";
                }
                if (serialnumber[i] == 'Y')
                {
                    encypstr += "60";
                }
                if (serialnumber[i] == 'Z')
                {
                    encypstr += "90";
                }
            }

            return encypstr;
        }


        public string Decryption(string serialnumber)
        {
            string decryptstr = "",str = "";

            for (int i = 0; i < serialnumber.Length;i=i+2)
            {
                str = Convert.ToString(serialnumber[i]);
                str += Convert.ToString(serialnumber[i + 1]);
                if (str == "AC")
                {
                    decryptstr += "1"; 
                }
                if (str == "EF")
                {
                    decryptstr += "2";
                }
                if (str == "DT")
                {
                    decryptstr += "3";
                }
                if (str == "RG")
                {
                    decryptstr += "4";
                }
                if (str == "LK")
                {
                    decryptstr += "5";
                }
                if (str == "MN")
                {
                    decryptstr += "6";
                }
                if (str == "PO")
                {
                    decryptstr += "7";
                }
                if (str == "SZ")
                {
                    decryptstr += "8";
                }
                if (str == "UJ")
                {
                    decryptstr += "9";
                }
                if (str == "XW")
                {
                    decryptstr += "0";
                }
                if (str == "47")
                {
                    decryptstr += "A";
                }
                if (str == "52")
                {
                    decryptstr += "B";
                }
                if (str == "61")
                {
                    decryptstr += "C";
                }
                if (str == "23")
                {
                    decryptstr += "D";
                }
                if (str == "98")
                {
                    decryptstr += "E";
                }
                if (str == "13")
                {
                    decryptstr += "F";
                }
                if (str == "08")
                {
                    decryptstr += "G";
                }
                if (str == "77")
                {
                    decryptstr += "H";
                }
                if (str == "36")
                {
                    decryptstr += "I";
                }
                if (str == "81")
                {
                    decryptstr += "J";
                }
                if (str == "42")
                {
                    decryptstr += "K";
                }
                if (str == "55")
                {
                    decryptstr += "L";
                }
                if (str == "67")
                {
                    decryptstr += "M";
                }
                if (str == "29")
                {
                    decryptstr += "N";
                }
                if (str == "91")
                {
                    decryptstr += "O";
                }
                if (str == "17")
                {
                    decryptstr += "P";
                }
                if (str == "03")
                {
                    decryptstr += "Q";
                }
                if (str == "72")
                {
                    decryptstr += "R";
                }
                if (str == "11")
                {
                    decryptstr += "S";
                }
                if (str == "32")
                {
                    decryptstr += "T";
                }
                if (str == "86")
                {
                    decryptstr += "U";
                }
                if (str == "07")
                {
                    decryptstr += "V";
                }
                if (str == "99")
                {
                    decryptstr += "W";
                }
                if (str == "30")
                {
                    decryptstr += "X";
                }
                if (str == "60")
                {
                    decryptstr += "Y";
                }
                if (str == "90")
                {
                    decryptstr += "Z";
                }

            }


            return decryptstr;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            /*  string folderPath = "";
              FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
              if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
              {
                  folderPath = folderBrowserDialog1.SelectedPath;
              }*/
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Open License file";
            fdlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fdlg.Filter = "License Files (LIC)|*.lic";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                filebrowse.Text = fdlg.FileName;
            }

        }

        private void regiter_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line, serialkey = "", validdays = "";

            if (filebrowse.Text == "")
                return;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(filebrowse.Text);

            //READ THE REGISTRATION FILE AND GET SERIAL NUMBER
            while ((line = file.ReadLine()) != null)
            {
                if (counter == 3)
                {
                    validdays = line.Replace("Product ID: ", "");
                    validdays = Decryption(validdays);
                }
                if (counter == 4)
                {
                    serialkey = line.Replace("Password: ", "");
                }
                counter++;
            }

            file.Close();

            string orignalkey = Decryption(serialkey);
            orignalkey = Decryption(orignalkey);

            string mac = GetMacAddress();
            string SerialNumber = Identifier("Win32_DiskDrive", "SerialNumber");
            SerialNumber = SerialNumber.Replace(" ", "");

            if (orignalkey == mac + SerialNumber)
            { 
            //------------REGISTRY----------------------------
            int period = Convert.ToInt32(validdays); // trial period
            string keyName = "Software\\GUID\\374DE290-123F-4565-9164-39C4925E467B";
            long ticks = DateTime.Today.Ticks;

            RegistryKey rootKey = Registry.CurrentUser;
            RegistryKey regKey = rootKey.OpenSubKey(keyName);

                if (regKey == null)
                {
                    regKey = rootKey.CreateSubKey(keyName);
                    long expiry = DateTime.Today.AddDays(period).Ticks;
                    regKey.SetValue("EGUID", expiry, RegistryValueKind.QWord);  //Expiration date caluclated from adding days

                    long todayticks = DateTime.Today.Ticks;
                    regKey.SetValue("TGUID", todayticks, RegistryValueKind.QWord); //Todays date

                    regKey.Close();
                }
                else
                regKey.Close();
                //------------------------------------------
                MessageBox.Show("Successfully Registered!");

           }
        }
        //CODES
        /*
         * 1   AC             A 47              K  42             V  07
         * 2   EF             B 52              L  55             W  99
         * 3   DT             C 61              M  67             X  30
         * 4   RG             D 23              N  29             Y  60  
         * 5   LK             E 98              O  91             Z  90 
         * 6   MN             F 13              P  17 
         * 7   PO             G 08              Q  03
         * 8   SZ             H 77              R  72
         *                                      S  11 
         * 9   UJ             I 36              T  32
         * 0   XW             J 81              U  86  
                                            
         */

    }
}
