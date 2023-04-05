using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinalProject_653450279_6
{
    public static class LoginSystem
    {
        // ระบบ Login
        private static List<ClassAdmin> Admin = new List<ClassAdmin>
    {
        new ClassAdmin { NameAdmin = "Pu", PassWord = "1234" },
    };

        public static bool Login(string adminname, string password)
        {
            ClassAdmin admin = Admin.Find(u => u.NameAdmin == adminname && u.PassWord == password);
            if (admin != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
