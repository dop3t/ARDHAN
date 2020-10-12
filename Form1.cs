using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xen_Roleplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void panelsidemenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void buttonconnect_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("fivem://connect/grandtheftauto.stateofindonesia.id"); 
        }

        private void buttonrules_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1OBcquvhKCHpwwe0aWJT5PlETrtXuNN2b6NaSaS2vDdA/edit?usp=sharing");
        }

        private void buttondiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/vyzuNk7");
        }

        private void buttondonate_Click(object sender, EventArgs e)
        {
             System.Diagnostics.Process.Start("fivem://connect/139.99.24.160:30122");
             System.Diagnostics.Process.Start("ts3server://soigta.gq"); 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonwebsite_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("fivem://connect/139.99.24.160:30122");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ts3server://soigta.gq:9987");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }
    }
}
