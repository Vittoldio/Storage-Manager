using StorageManager.Enumirations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageManager.TaskManager;

namespace StorageManager.Data
{
    internal class DB_plug_task
    {
        List<string> taskOwner;
        List<string> taskPerformer;
        List<TaskType> taskType;

        public List<Task_> gotTasks;
        public DB_plug_task()
        {
            SQLData data = new SQLData();
            List<string> gotData = new List<string>();

            this.taskOwner = new List<string>();
            this.taskPerformer = new List<string>();
            this.taskType = new List<TaskType>();

            gotData = data.Get_tasks();

            TaskType taskData = new TaskType();
            for (int i = 0;i < gotData.Count;i += 3) 
            {
                this.taskOwner.Add((string)gotData[i + 1]);
                this.taskPerformer.Add((string)gotData[i + 2]);

                if (gotData[i + 2] == "0")
                {
                    this.taskType.Add(TaskType.relocation);
                } else 
                if (gotData[i + 2] == "1")
                {
                    this.taskType.Add(TaskType.sell);
                }else 
                if (gotData[i + 2] == "2")
                {
                    this.taskType.Add(TaskType.remove);
                }
                else
                {
                    throw new Exception("Db sucks");
                }
            }
            this.gotTasks = new List<Task_>();
            for(int i = 0;i < this.taskOwner.Count;i++)
            {
                this.gotTasks.Add(new Task_(this.taskOwner[i], this.taskPerformer[i], "", this.taskType[i]));
            }

        }


    }
}
