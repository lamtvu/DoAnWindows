using GantChart.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Drawing.Printing;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GantChart.Controllers
{
    class TaskController
    {
        public static List<TaskWork> GetListTask()
        {
            using (var _context = new DbGantChartContext())
            {
                var task = (from t in _context.TaskWorks.Include(t => t.Users)
                            select t).ToList();
                            
                return task;
            }
        }
        public static void AddTask(TaskWork taskWork)
        {
            using (var _context = new DbGantChartContext())
            {
                TaskWork taskWork1 = new TaskWork();
                foreach (User user in taskWork.Users)
                {
                    var userdb = (from u in _context.Users.Include(u=>u.Tasks)
                                  where u.UserName == user.UserName
                                  select u).Single();
                    userdb.Tasks.Add(taskWork);
                }
                taskWork.Users.Clear();
                _context.TaskWorks.Add(taskWork);
                _context.SaveChanges();
            }
        }
        public static void DeleteTask(int ID)
        {
            using (var _context = new DbGantChartContext())
            {
                var task = (from t in _context.TaskWorks.Include(x=>x.Users)
                            where t.ID == ID
                            select t).Single();
                _context.TaskWorks.Remove(task);
                _context.SaveChanges();
            }
        }
        public static void EditTask(TaskWork task)
        {
            using (var _context = new DbGantChartContext())
            {
                var taskdb = (from t in _context.TaskWorks.Include(x => x.Users)
                            where t.ID == task.ID
                            select t).Single();
                taskdb.Title = task.Title;
                taskdb.description = task.description;
                taskdb.FromDate = task.FromDate;
                taskdb.ToDate = task.ToDate;
                taskdb.PercentCompleted = task.PercentCompleted;
                taskdb.Priority = task.Priority;
                taskdb.Url = task.Url;
                taskdb.Users.Clear();
                
                
                foreach (User user in task.Users)
                {
                    var userdb = (from u in _context.Users.Include(u => u.Tasks)
                                  where u.UserName == user.UserName
                                  select u).Single();
                    taskdb.Users.Add(userdb);
                }
                _context.SaveChanges();

            }
        }
        public static TaskWork GetTask(int ID)
        {
            using (var _context = new DbGantChartContext())
            {
                var task = (from t in _context.TaskWorks.Include(x => x.Users)
                            where t.ID == ID
                            select t).Single();
                return task;
            }
        }
    }
}