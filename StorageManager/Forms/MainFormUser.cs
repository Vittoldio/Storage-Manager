using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager
{
    public partial class MainFormUser : Form
    {
        
        public MainFormUser()
        {
            InitializeComponent();
            VisualInit();
            
        }
        public void ScheduleCreating()
        {

        }
        public void VisualInit()
        {
            this.MinimumSize = new Size(800, 600);
            this.MaximumSize = new Size(800, 600);
            this.TaskSchedulerBox.Text = "Schedule";
            this.UserNameLabel.Text = Program.UserName;
        }
    }
}
