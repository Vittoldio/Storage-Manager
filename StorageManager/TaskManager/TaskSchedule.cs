using StorageManager.Enumirations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.TaskManager
{
    class TaskSchedule
    {
        private List<Task_>? tasks;
        public TaskSchedule(List<Task_> tasks)
        {
            this.tasks = tasks;
        }
        public TaskSchedule()
        {
            /*
             * get from db
             * this.tasks = GetSchedule_fromDB()
             */
            this.tasks = new List<Task_>();
        }
        private List<Task_> GetSchedule_fromDB()
        {
            List<Task_> list = new List<Task_>();
            return list;
        }
        public void AddTask(Task_ task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(Task_ task)
        {
            tasks.Remove(task);
        }

        public List<Task_> GetMySchedule(string login) // не знаю, какое там юзать будем
        {
            List<Task_> schedule = new List<Task_>();
            foreach (var task in tasks)
            {
                if (task.TaskPerfomer == login)
                {
                    schedule.Add(task);
                }
            }
            return schedule;
        }
    }
}
