using StorageManager.Enumirations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.TaskManager
{
    class TaskScheduler
    {
        List<Task> tasks;
        public TaskScheduler(List<Task> tasks)
        {
            this.tasks = tasks;
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
        }

        public List<Task> GetMySchedule(string login) // не знаю, какое там юзать будем
        {
            List<Task> schedule = new List<Task>();
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
