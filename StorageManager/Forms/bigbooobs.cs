using StorageManager.Data;
using StorageManager.Enumirations;
using StorageManager.TaskManager;
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
        //DB_plug_task dB_Plug_Task = new DB_plug_task();
        DB_plug_user users = new DB_plug_user();
        private void UpdateComboBoxes()
        {
            /*for(int i = 0; i < dB_Plug_Task.gotTasks.Count; i++)
            {
                comboBox2.Items.Add(dB_Plug_Task.gotTasks[i].TaskPerfomer);
                comboBox3.Items.Add(dB_Plug_Task.gotTasks[i].TaskType);
            }*/
            for(int i = 0;i < users.login.Count; i++)
            {
                if (users.login[i] != null) 
                {
                    comboBox2.Items.Add(users.login[i]);
                }
            }
            comboBox3.Items.Add(TaskType.sell);
            comboBox3.Items.Add(TaskType.relocation);
            comboBox3.Items.Add(TaskType.remove);
            textBox2.Text = Program.login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex== -1)
            {
                return;
            }

            UpdateSql sql = new UpdateSql();
            Task_ newTask = new Task_(Program.login, comboBox2.SelectedItem.ToString(), "",(TaskType)comboBox3.SelectedItem);
            sql.AddTask(newTask);
        }
    }
}
