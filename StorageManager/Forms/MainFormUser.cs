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

namespace StorageManager
{
    public partial class MainFormUser : Form
    {
        const int locateStep = 20; //px
        int stepAtMoment = 20;
        
        public MainFormUser()
        {
            InitializeComponent();
            scheduleBase = tasks.GetMySchedule(Program.UserName);
            VisualInit();
            
        }

        TaskSchedule tasks = new TaskSchedule();
        List<Task_> scheduleBase = new List<Task_>() ;
        public void VisualInit()
        {
            this.MinimumSize = new Size(800, 600);
            this.MaximumSize = new Size(800, 600);
            this.TaskSchedulerBox.Text = "Schedule";
            this.UserNameLabel.Text = Program.UserName;
        }
    }
}
