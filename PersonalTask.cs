using System;

namespace TaskManagementSystem
{
    public class PersonalTask : Task
    {
        public PersonalTask(string title, string description,
                            string priority, DateTime dueDate,
                            bool completed)
            : base(title, description, priority, dueDate, completed)
        {
        }

        public override string GetTaskType()
        {
            return "Personal Task";
        }
    }
}