using StorageManager.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager.Forms
{
    public partial class bigbooobs : Form
    {
        public bigbooobs()
        {
            InitializeComponent();
            UpdateComboBoxes();
        }
        DB_plug_task dB_Plug_Task = new DB_plug_task();
        private void UpdateComboBoxes()
        {
            for(int i = 0; i<dB_Plug_Task.taskOwner.Count; i++)
            {
                
                comboBox2.Items.Add(dB_Plug_Task.taskPerformer[i].ToString());
                comboBox3.Items.Add(dB_Plug_Task.taskType[i].ToString());
            }
            textBox2.Text = Program.login;
        }
    }
}
