using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


        public string getGUID()
        {
            string key = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography";
            string r = (string)Registry.GetValue(key, "MachineGuid", (object)"default");
            return r;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            computerName.Text += Environment.MachineName;
            machineGUID.Text += getGUID();
        }
    }
}
