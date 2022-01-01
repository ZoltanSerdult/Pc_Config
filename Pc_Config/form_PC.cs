using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pc_Config
{
    public partial class Form_PC : Form
    {
        public Form_PC()
        {
            InitializeComponent();
        }

        private void form_PC_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(OS)))
            {
                comboBox_OS.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OS rendszer = (OS)Enum.Parse(typeof(OS), comboBox_OS.SelectedItem.ToString());
            PC uj = new PC(
                textBox_ConfigNev.Text,
                textBox_Tulaj.Text,
                checkBox_Gamer.Checked,
                rendszer
                );
            Program.form1.listBox_Mutat.Items.Add(uj);
            
        }
    }
}
