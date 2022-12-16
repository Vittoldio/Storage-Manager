using StorageManager.Data;
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
        //private List<DB_plug_task> tasks;
        private DB_plug_task tasks;
        public TaskSchedule(DB_plug_task tasks)
        {
            this.tasks = tasks;
        }
       /* 
        public void AddTask(Task_ task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(Task_ task)
        {
            tasks.Remove(task);
        }
       */
        public List<Task_> GetMySchedule_ByLogin(string login) // не знаю, какое там юзать будем
        {
            List<Task_> schedule = new List<Task_>();
            foreach (var task in this.tasks.gotTasks)
            {
                if (task.TaskPerfomer == login)
                {
                    schedule.Add(task);
                }
            }
            return schedule;
        }

        public List<Task_> GetMySchedule_ByPerformer(Task_ performer) // не знаю, какое там юзать будем
        {
            List<Task_> schedule = new List<Task_>();
            foreach (var task in this.tasks.gotTasks)
            {
                if (task.TaskPerfomer == performer.TaskPerfomer)
                {
                    schedule.Add(task);
                }
            }
            return schedule;
        }
    }
}
