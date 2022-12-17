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
        SQLData data = new SQLData(); //для синхры БД и таблиц наших
        private void UpdateTable() //метод обновы таблицы пользователей, работает, но немного криво, типа
            //надо пофиксить то, что в столбец логин подаётся пассворд, а не логин
        {
            for(int i = 0; i<data.Get_id_login_password().Count;i++)
            {
                dataGridView2.RowCount++;
            }
            for(int i = 1; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2.Rows[i].Cells[i].Value = data.Get_id_login_password()[i];
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
    }
}
