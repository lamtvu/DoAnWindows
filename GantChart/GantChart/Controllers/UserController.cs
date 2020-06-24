using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using GantChart.Controllers;
using GantChart.Models;

namespace GantChart.Controllers
{
    class UserController
    {
        public static List<User> GetListUser()
        {
            using (var _context = new DbGantChartContext())
            {
                var users = _context.Users
                    .Include(t => t.Tasks);
                    
                var listUser = from u in users
                            select u;
                return listUser.ToList();
            }
        }
        public static void AddUser(User user)
        {
            using (var _context = new DbGantChartContext())
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
        }
        public static void DeleteUser(User user)
        {
            using (var _context = new DbGantChartContext())
            {
                var dbUser = (from u in _context.Users.Include(x=>x.Tasks)
                              where u.UserName == user.UserName
                              select u).SingleOrDefault();
                _context.Users.Remove(dbUser);
                _context.SaveChanges();
            }
        }
        public static int UpdateUser(User user)
        {
            using (var _context = new DbGantChartContext())
            {

                if (GetUser(user.UserName) == null)
                {
                    return -1;
                }
                _context.Users.AddOrUpdate(user);
                _context.SaveChanges();
                return 1;
            }
        }
        public static User GetUser(string username)
        {
            using (var _context = new DbGantChartContext())
            {
                
                var dbUser = (from u in _context.Users.Include("Tasks.Users")
                              where u.UserName == username
                              select u).SingleOrDefault();
                return dbUser;
            }
        }
        public static List<User> GetListUser(string username)
        {
            using (var _context = new DbGantChartContext())
            {
                var user = _context.Users.Where(u => u.UserName.Contains(username));
                return user.ToList();
            }
        }
    }
}