
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using TestEFCodeFirst;

namespace trying
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Context _context = new Context();
            //TaskToDo t1 = new TaskToDo();
            //t1.Description = "Test";
            //t1.DateToDo = new DateOnly(200, 01, 01);
            //TaskToDo t2 = new TaskToDo();
            //t2.Description = "Wash";
            //t2.DateToDo = new DateOnly(200, 01, 03);
            //CyclicTask c = new CyclicTask();
            //c.Description = "Shopping";
            //c.DateToDo = new DateOnly(200, 01, 06);
            //_context.TasksToDo.Add(t1);
            //_context.TasksToDo.Add(t2);
            //_context.CyclicTasks.Add(c);
            //_context.SaveChanges();
            foreach (var item in TasksToNextMonth(01, 200).Result)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static async Task<List<TaskToDo>> TasksToNextMonth(int month, int year)
        {
            Context _context = new Context();
            CyclicTask temp;
            DateOnly tempDate;
            List<TaskToDo> result= new List<TaskToDo>();
            foreach (var task in _context.TasksToDo.ToList())
            {
                if (task.DateToDo.Month == month&& task.DateToDo.Year==year)
                {
                    result.Add(task);
                    if (task is CyclicTask) {
                        tempDate = task.DateToDo;
                        while (tempDate.AddDays(7).Month == month)
                        {
                            tempDate=tempDate.AddDays(7);
                            temp = new CyclicTask();
                            temp.DateToDo = tempDate;
                            temp.Id= task.Id;   
                            temp.Description= task.Description;
                            temp.DayInWeek = (task as CyclicTask).DayInWeek;
                            result.Add(temp);   
                        }
                    }
                }
            }
            return await Task.FromResult(result); 
        }
    }
}