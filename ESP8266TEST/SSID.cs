using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESP8266TEST
{
    public partial class SSID : Form
    {
        Form1 theform;
        public SSID(Form1 form)
        {
            InitializeComponent();
            theform = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            theform.Password = textBoxPassword.Text.ToString();
            this.Close();
        }
    }
}
