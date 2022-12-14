using StorageManager.Enumirations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.TaskManager
{
    class Task
    {
        private string taskOwner;
        public string TaskOwner { get { return taskOwner; } }

        private string taskPerformer;
        public string TaskPerfomer { get { return taskPerformer; } }

        private string taskDescribe;// ХЗ нужно ли
        public string TaskDescribe { get { return taskDescribe; } }

        private TaskType taskType;
        public TaskType TaskType { get { return taskType; } }

        public Task(string taskOwner, string taskPerformer, string taskDescribe, TaskType taskType)
        {
            this.taskType = taskType;
            this.taskOwner = taskOwner;
            this.taskPerformer = taskPerformer;
            this.taskDescribe = taskDescribe;
        }

    }
}
