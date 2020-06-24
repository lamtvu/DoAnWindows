using GantChart.Controllers;
using GantChart.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GantChart.Controllers
{
    class ListController
    {
        public static List<User> GetListSearch(string username)
        {
            List<User> listuser = UserController.GetListUser();
            if (username != "")
            {
                listuser = listuser.Where(u => u.UserName.Contains(username)).ToList();
            }
            
            return listuser;

        }
        public static DateTime MaxToDate(List<TaskWork> listTask)
        {
            DateTime max = listTask[0].FromDate;
            for (int i = 0; i < listTask.Count; i++)
            {
                if (max < listTask[i].ToDate)
                {
                    max = listTask[i].ToDate;
                }
            }
            return max;
        }//tim ngay bat dau nho nhat
        public static DateTime MinFromDate(List<TaskWork> listTask)
        {
            DateTime min = listTask[0].ToDate;
            for (int i = 0; i < listTask.Count; i++)
            {
                if (min > listTask[i].FromDate)
                {
                    min = listTask[i].FromDate;
                }
            }
            return min;
        }//tim ngay ket thuc nho nhat
    }
}