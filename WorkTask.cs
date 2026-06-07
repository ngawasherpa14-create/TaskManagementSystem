using System;

namespace TaskManagementSystem
{
    public class WorkTask : Task
    {
        public WorkTask(string title, string description,
                        string priority, DateTime dueDate,
                        bool completed)
            : base(title, description, priority, dueDate, completed)
        {
        }

        public override string GetTaskType()
        {
            return "Work Task";
        }
    }
}