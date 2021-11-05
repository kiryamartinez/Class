using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Виталий");
            User user2 = new User("Александр");
            List list = new List(new Task[] {new Task(user,"Помыть пол"), new Task(user2,"Купить еду") });
            list.ShowAllTasks();
        }
    }

    class User
    {
        public string Name;
        public User(string name)
        {
            Name = name;
        }
    }
    class Task
    {
        public User Worker;
        public string Description;
        public Task(User worker, string desctiprion)
        {
            Worker = worker;
            Description = desctiprion;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Ответсвенный: " + Worker.Name + "\nОписание задачи: " + Description);
        }
    }
    class List
    {
        public Task[] Tasks;
        public List(Task[] tasks)
        {
            Tasks = tasks;
        }
        public void ShowAllTasks()
        {
            for (int i = 0; i < Tasks.Length; i++)
            {
                Tasks[i].ShowInfo();
            }
        }
    }
}
