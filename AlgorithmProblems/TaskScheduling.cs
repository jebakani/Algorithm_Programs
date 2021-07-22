using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class Schedule
    {
        public int deadLine;
        public int taskCompletionTime;
        public int done;

        //create the slot for task with deadline and taskCompletion time
       public Schedule(int deadline, int taskCompletionTime)
        {
            this.deadLine = deadline;
            this.taskCompletionTime = taskCompletionTime;
        }
    }
    class TaskScheduling
    {
        public void JobSchedule()
        {
            //get the input from the user
            Console.WriteLine("Total number of task");
            int n = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            int done = 0;
            List<Schedule> sch = new List<Schedule>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter deadline of task{0}",i+1);
                int deadLine = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter completion time of task{0}", i + 1);
                int taskCompletionTime = Convert.ToInt32(Console.ReadLine());
                Schedule s = new Schedule(deadLine, taskCompletionTime);
                sch.Add(s);
            }
            //sort the list accorting to the deadline
            List<Schedule> sortSchedule = sch.OrderBy(x => x.deadLine).ToList();
            foreach(var l in sortSchedule)
            {
                //check how much the task done overshoot the dead line
                done += l.taskCompletionTime;
                max= Math.Max(max, done - l.deadLine);
                Console.WriteLine(max);
            }

        }
    }


    
}
