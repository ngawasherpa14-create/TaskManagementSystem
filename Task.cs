using System;

namespace TaskManagementSystem
{
    // Base class (Abstraction)
    public abstract class Task
    {
        // Encapsulation
        private string title;
        private string description;
        private string priority;
        private DateTime dueDate;
        private bool completed;

        // Properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public bool Completed
        {
            get { return completed; }
            set { completed = value; }
        }

        // Constructor
        public Task(string title, string description,
                    string priority, DateTime dueDate, bool completed)
        {
            Title = title;
            Description = description;
            Priority = priority;
            DueDate = dueDate;
            Completed = completed;
        }

        // Polymorphism
        public abstract string GetTaskType();
    }
}