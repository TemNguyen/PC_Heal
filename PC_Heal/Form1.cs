using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Management;

namespace PC_Heal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StaticInformation();
            timer1.Start();
        }
        void StaticInformation()
        {
            using (var computer_System = new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
            {
                foreach (var item in computer_System)
                {
                    tbCName.Text = item["Name"].ToString();
                    tbNPhyCore.Text = item["NumberOfProcessors"].ToString();
                    tbNLCore.Text = item["NumberOfLogicalProcessors"].ToString();
                    //Console.WriteLine("Computer Name: " + item["Name"]);
                    //Console.WriteLine("Number Of Physical Processor: " + item["NumberOfProcessors"]);
                    //Console.WriteLine("Number Of Logical Processors: {0}", item["NumberOfLogicalProcessors"]);
                }
            }

            using (var processor = new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                foreach (var item in processor)
                {
                    tbCoreName.Text = item["Name"].ToString();

                    //Console.WriteLine("Processor Name: " + item["Name"]);
                    //Console.WriteLine("Number Of Cores: {0}", item["NumberOfCores"]);
                }
            }

            ManagementClass mgmt = new ManagementClass("Win32_NetworkAdapterConfiguration");
            //create our ManagementObjectCollection to get the attributes with
            ManagementObjectCollection objCol = mgmt.GetInstances();
            string address = String.Empty;
            //loop through all the objects we find
            foreach (ManagementObject obj in objCol)
            {
                if (address == String.Empty)  // only return MAC Address from first card
                {
                    //grab the value from the first network adapter we find
                    //you can change the string to an array and get all
                    //network adapters found as well
                    if ((bool)obj["IPEnabled"] == true) address = obj["MacAddress"].ToString();
                }
                //dispose of our object
                obj.Dispose();
            }

            tbMAC.Text = address;
            string IP = String.Empty;
            string MAC = String.Empty;

            using (var network = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {


                foreach(var item in network.GetInstances())
                {
                    if (MAC == String.Empty)
                    {
                        if ((bool)item["IPEnabled"] == true)
                        {
                            MAC = item["MACAddress"].ToString();
                            String[] IPs = (String[])item["IPAddress"];
                            IP = IPs[0];
                        }                          
                    }
                }
            }
            tbIP.Text = IP;
            tbMAC.Text = MAC;

        }
        void NonStaticInformation()
        {
            DriveInfo dDisk = new DriveInfo("D");
            DriveInfo cDisk = new DriveInfo("C");

            tbDCFree.Text = ((cDisk.AvailableFreeSpace / (float)cDisk.TotalSize) * 100).ToString("00.00") + "%";
            tbDDfree.Text = ((dDisk.AvailableFreeSpace / (float)dDisk.TotalSize) * 100).ToString("00.00") + "%";

            using (var processor = new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_PerfFormattedData_PerfOS_Processor").Get())
            {
                foreach(var item in processor)
                {
                    tbCPU.Text = item["PercentProcessorTime"].ToString() + "%";
                }
            }

            using (var operating = new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_OperatingSystem").Get())
            {
                foreach(var item in operating)
                {
                    tbRAM.Text = ((int.Parse(item["FreePhysicalMemory"].ToString()) / (float)int.Parse(item["TotalVisibleMemorySize"].ToString())) * 100).ToString("00.00") + "%";
                }
            }

            //using (var temperature = new ManagementObjectSearcher("root\\WMI",
            //        "SELECT * FROM MSAcpi_ThermalZoneTemperature").Get())
            //{
            //    foreach(var item in temperature)
            //    {
            //        tbTemp.Text = (float.Parse(item["CurrentTemperature"].ToString()) / 10 - 273.15).ToString("00.0");
            //    }
            //}

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NonStaticInformation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(numericUpDown1.Value);

            string cmd = "/c shutdown -s -t " + s.ToString();

            System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\cmd.exe", cmd);
        }
    }
}
