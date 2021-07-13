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
using System.Net.NetworkInformation;
using System.Data.OleDb;

namespace RegistrationManager
{
    public partial class RgistrationManager : Form
    {
        public RgistrationManager()
        {
            InitializeComponent();
        }

        private void GenerateLicense_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (RegistrationKey.Text == "")
            {

                MessageBox.Show("Error : Enter Registration key");
                flag = false;
            }

            if(ProductName.Text=="")
            {
                MessageBox.Show("Error : Enter Product Name");
                flag = false;
            }

            if (Numbertext.Text == "")
            {
                MessageBox.Show("Error : Enter Number Text");
                flag = false;
            }


            //IF ALL DETAILS ARE FILLED THEN PROCESS THE CODE
            if (flag == true)
            {
                int counter = 0;
                string line,serialkey="";

                // Read the file and display it line by line.  
                System.IO.StreamReader file =
                    new System.IO.StreamReader(RegistrationKey.Text);
                
                //READ THE REGISTRATION FILE AND GET SERIAL NUMBER
                while ((line = file.ReadLine()) != null)
                {
                    if (counter == 11)
                    {
                        serialkey = line.Replace("User Serial Number: ", "");
                    }
                    counter++;
                }

                file.Close();


                string Encrypserialnumber = Encryption(serialkey);  //ENCRYPTION OF SERIAL NUMBER


                //WRITE DETAILS IN FILE OF LICENSE FILE
                string[] lines =
               {

                         "Product Version: 11.2",
                         "Number of days: "+Numbertext.Text,
                         "Product Name: "+ProductName.Text,
                         "Product ID: "+ Encryption(Numbertext.Text),
                         "Password: "+Encrypserialnumber
                };

                File.WriteAllLinesAsync(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DemoAppLicense.lic", lines);

                WritetoExcel();

                MessageBox.Show("Sucessfully License File created on your Desktop");
            }

        }

        private void Browse_Click(object sender, EventArgs e)
        {
            //  File.WriteAllLinesAsync(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Registration.key",line);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Open Registration key";
            fdlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fdlg.Filter = "Key Files (KEY)|*.key"; 
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                RegistrationKey.Text = fdlg.FileName;

                int counter = 0;
                string line;

                // Read the file and display it line by line.  
                System.IO.StreamReader file =
                    new System.IO.StreamReader(RegistrationKey.Text);

                //READ THE REGISTRATION FILE AND GET SERIAL NUMBER
                while ((line = file.ReadLine()) != null)
                {
                    if (counter == 10)
                    {
                        ProductName.Text = line.Replace("Product Name: ", "");
                    }
                    counter++;
                }

                file.Close();
            }
        }

        void WritetoExcel()
        {
            string path = Application.StartupPath + "Database\\test" + ".xls";
            string[] data = new String[13]; 
            string line = "";
            int count = 1;

            if (File.Exists(path))
            {
                System.IO.StreamReader file = new System.IO.StreamReader(RegistrationKey.Text);

                //READ THE REGISTRATION FILE AND GET SERIAL NUMBER
                while ((line = file.ReadLine()) != null)
                {
                    if (count == 1)
                        data[0] = line.Replace("Company Name: ", "") + ",";
                    if (count == 2)
                        data[1] = line.Replace("Contact Name: ", "") + ",";
                    if (count == 3)
                        data[2] = line.Replace("Email ID: ", "") + ",";
                    if (count == 4)
                        data[3] = line.Replace("Phone number: ", "") + ",";
                    if (count == 5)
                        data[4] = line.Replace("Address: ", "") + ",";
                    if (count == 6)
                        data[5] = line.Replace("City: ", "") + ",";
                    if (count == 7)
                        data[6] = line.Replace("State: ", "") + ",";
                    if (count == 8)
                        data[7] = line.Replace("Zip Code: ", "") + ",";
                    if (count == 9)
                        data[8] = line.Replace("Country: ", "") + ",";
                    if (count == 10)
                        data[9] = line.Replace("Number of Users: ", "") + ",";
                    if (count == 11)
                        data[10] = line.Replace("Product Name: ", "") + ",";
                    if (count == 12)
                        data[11] = line.Replace("User Serial Number: ", "") + ",";

                    count++;
                }

                file.Close();

                String filename = path;
                String connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filename + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1;\"";
                String Command = "insert into [Sheet1$](Name,age) values('22','24')";
                OleDbConnection con = new OleDbConnection(connection);
                con.Open();
                OleDbCommand cmd = new OleDbCommand(Command, con);
                cmd.ExecuteNonQuery();

            }
            else
                MessageBox.Show("Database file doesnt exist");
        }

        /*  void WritetoExcel(string EncrptedID)
          {
              string path = Application.StartupPath + "\\Database\\License_Details" + ".csv";
              string data = "",line="";
              int count = 1;

              if (File.Exists(path))
              {
                  System.IO.StreamReader file = new System.IO.StreamReader(RegistrationKey.Text);

                  //READ THE REGISTRATION FILE AND GET SERIAL NUMBER
                  while ((line = file.ReadLine()) != null)
                  {
                      if (count == 1)
                          data += line.Replace("Company Name: ", "")+",";
                      if(count == 2)
                          data += line.Replace("Contact Name: ", "") + ",";
                      if (count == 3)
                          data += line.Replace("Email ID: ", "") + ",";
                      if (count == 4)
                          data += line.Replace("Phone number: ", "") + ",";
                      if (count == 5)
                          data += line.Replace("Address: ", "") + ",";
                      if (count == 6)
                          data += line.Replace("City: ", "") + ",";
                      if (count == 7)
                          data += line.Replace("State: ", "") + ",";
                      if (count == 8)
                          data += line.Replace("Zip Code: ", "") + ",";
                      if (count == 9)
                          data += line.Replace("Country: ", "") + ",";
                      if (count == 10)
                          data += line.Replace("Number of Users: ", "") + ",";
                      if (count == 11)
                          data += line.Replace("Product Name: ", "") + ",";
                      if (count == 12)
                          data += line.Replace("User Serial Number: ", "") + ",";

                      count++;
                  }

                  file.Close();

                  File.AppendAllText(path, data + "\n");

              }
              else
              {
                  File.WriteAllText(path, "Company Name,Contact Name,Email ID,Phone Number,Address,City,State,Zip Code,Country,Number of Users,Product Name,User Serial Number\n");

                  System.IO.StreamReader file = new System.IO.StreamReader(RegistrationKey.Text);

                  //READ THE REGISTRATION FILE AND GET SERIAL NUMBER

                  while ((line = file.ReadLine()) != null)
                  {
                      if (count == 1)
                          data += line.Replace("Company Name: ", "") + ",";
                      if (count == 2)
                          data += line.Replace("Contact Name: ", "") + ",";
                      if (count == 3)
                          data += line.Replace("Email ID: ", "") + ",";
                      if (count == 4)
                          data += line.Replace("Phone number: ", "") + ",";
                      if (count == 5)
                          data += line.Replace("Address: ", "") + ",";
                      if (count == 6)
                          data += line.Replace("City: ", "") + ",";
                      if (count == 7)
                          data += line.Replace("State: ", "") + ",";
                      if (count == 8)
                          data += line.Replace("Zip Code: ", "") + ",";
                      if (count == 9)
                          data += line.Replace("Country: ", "") + ",";
                      if (count == 10)
                          data += line.Replace("Number of Users: ", "") + ",";
                      if (count == 11)
                          data += line.Replace("Product Name: ", "") + ",";
                      if (count == 12)
                          data += line.Replace("User Serial Number: ", "") + ",";

                      count++;
                  }

                  file.Close();

                  File.AppendAllText(path, data + "\n");
              }
          }*/
        public string Encryption(string serialnumber)
        {
            string encypstr = "";

            for (int i = 0; i < serialnumber.Length; i++)
            {
                if (serialnumber[i] == '1')
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
            string decryptstr = "", str = "";

            for (int i = 0; i < serialnumber.Length; i = i + 2)
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
