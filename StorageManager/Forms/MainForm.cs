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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            SetPermissions();
            UpdateTable();
            
        }
       private void UpdateTable() //метод обновы таблицы пользователей
       {
            SQLData data = new SQLData();
            List<string> list = new List<string>();
            list = data.Get_id_login_password();
            for(int i = 0; i < list.Count; i += 3)
            {
                string[] s =
                {
                list[i],
                list[i + 1],
                list[i + 2]
                };
                dataGridView2.Rows.Add(s);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.AllowUserToAddRows = true;
            dataGridView2.AllowUserToDeleteRows = true;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AllowUserToResizeColumns = true;
            dataGridView2.AllowUserToResizeRows = true;
        }
        //пермишонсы для редактирования, в дальнейшем
        //просто раскидаем по кнопкам всё такое крутое\\\\\\\\\\\
        private void SetPermissions()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToOrderColumns = false;
            dataGridView3.AllowUserToResizeColumns = false;
            dataGridView3.AllowUserToResizeRows = false;
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AllowUserToOrderColumns = false;
            dataGridView4.AllowUserToResizeColumns = false;
            dataGridView4.AllowUserToResizeRows = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bigbooobs bigbooobs = new bigbooobs();
            bigbooobs.ShowDialog();
        }
    }
}
