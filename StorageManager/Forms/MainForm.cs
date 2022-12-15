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
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"huita.txt");
            for(int i = 0; i<dataGridView1.Rows.Count - 1; i++)
            {
                for(int j=0; j<dataGridView1.Columns.Count; j++)
                {
                    string? s = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    writer.Write(s + " ");
                }
                writer.WriteLine();
            }
            writer.Close();
        }
    }
}
