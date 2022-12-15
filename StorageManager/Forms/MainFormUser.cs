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
        const int locateStep = 30; //px
        int stepAtMoment = 20;
        
        public MainFormUser()
        {
            Task_ t = new Task_("goodman", "", "", Enumirations.TaskType.sell);
            Task_ t1 = new Task_("person", "", "", Enumirations.TaskType.relocation);
            Task_ t2 = new Task_("beer", "", "", Enumirations.TaskType.sell);
            this.scheduleBase.Add(t);
            this.scheduleBase.Add(t1);
            this.scheduleBase.Add(t2);
            this.scheduleBase.Add(t2);
            this.scheduleBase.Add(t2);
            this.scheduleBase.Add(t2);
            this.scheduleBase.Add(t2);
            this.scheduleBase.Add(t2);
            this.scheduleBase.Add(t2);
            this.scheduleBase.Add(t2);
            this.scheduleBase.Add(t2);
            this.scheduleBase.Add(t2);
            this.scheduleBase.Add(t2);
            this.scheduleBase.Add(t2);

            InitializeComponent();
            this.TaskSchedulerBox.AutoScroll = true;
            VisualInit();

            for(int i = 0;i < scheduleBase.Count; i++)
            {
                this.TaskSchedulerBox.Controls.Add(labels[i]);
            }
            
        }
        

        TaskSchedule tasks = new TaskSchedule();
        List<Task_> scheduleBase = new List<Task_>();
        List<Label> labels = new List<Label>();
        
        void VisualInit()
        {

            this.MinimumSize = new Size(800, 600);
            this.MaximumSize = new Size(800, 600);
            this.TaskSchedulerBox.Text = "Schedule";
            //this.UserNameLabel.Text = Program.UserName;
            ScheduleFormer();
        }
        void ScheduleFormer()
        {
            //Label[] labels = new Label[scheduleBase.Count];
            for (int i = 0; i < scheduleBase.Count; i++)
            {
                this.labels.Add(new Label());
                this.labels[i].AutoSize = true;
                if (this.scheduleBase[i].TaskType == Enumirations.TaskType.sell)
                {
                    this.labels[i].Text = "Sell, by " + $"{this.scheduleBase[i].TaskOwner}";
                }
                if (this.scheduleBase[i].TaskType == Enumirations.TaskType.remove)
                {
                    this.labels[i].Text = "Remove, by " + $"{this.scheduleBase[i].TaskOwner}";
                }
                if (this.scheduleBase[i].TaskType == Enumirations.TaskType.relocation)
                {
                    this.labels[i].Text = "Relocation, by " + $"{this.scheduleBase[i].TaskOwner}";
                }
                this.labels[i].Location = new Point(locateStep, this.stepAtMoment);
                this.stepAtMoment += locateStep * 3;
                
            }


        }
    }
}
