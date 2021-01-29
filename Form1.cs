using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plutonium_ban_bypass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        [DllImport("kernel32.dll")]
        static extern bool SetComputerName(string lpComputerName);

        public string getGUID()
        {
            string key = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography";
            string r = (string)Registry.GetValue(key, "MachineGuid", (object)"default");
            return r;
        }
        
        public void setNewGUID(string currentGUID)
        {
            string key = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography";
            Guid newGuid = Guid.NewGuid();
            Registry.SetValue(key, (string)Registry.GetValue(key, "MachineGuid", (object)"default"), newGuid.ToString());
            MessageBox.Show("Old GUID:" + currentGUID + "\nNew GUID: " + newGuid.ToString());
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            computerName.Text += Environment.MachineName;
            machineGUID.Text += getGUID();
        }
        public bool setNewComputerName(string name)
        {
            bool success = SetComputerName(name);
            return success;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            setNewGUID(getGUID());
        }

        private void setComputerName_Click(object sender, EventArgs e)
        {
            string newName = computerNameField.Text;
            if (newName == "" || newName == null) {
                MessageBox.Show("Field can't be empty");
            }
            else
            {
                if (setNewComputerName(newName))
                {
                    MessageBox.Show("Changed your computer's name, make sure to reboot afterwards.");
                }
                else
                {
                    MessageBox.Show("It didn't work. You need to run this as admin!");
                }
            }

        }
    }
}
