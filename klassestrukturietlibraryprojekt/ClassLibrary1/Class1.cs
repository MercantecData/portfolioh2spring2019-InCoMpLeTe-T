using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Registry
    {
        List<User> User = new List<User>();
        List<Admin> Admin = new List<Admin>();
        
        public void AddNewUser(User user)
        {
            this.User.Add(user);
        }
        

        public bool Login(string login, string password)
        {
            int i = 0;
            bool b = false; 
            while (i < this.User.Count)
            {
                if (this.User[i].ToString().Contains(login) && this.User[i].ToString().Contains(password))
                {
                    b = true; 
                }
                i = i + 1; 
            }
            i = 0;
            while (i < this.Admin.Count)
            {
                if (this.Admin[i].ToString().Contains(login) && this.Admin[i].ToString().Contains(password))
                {
                    b = true;
                }
                i = i + 1;
            }
            i = 0;
            return b;


        }
    }

    public class User
    {
        private string login;
        private string password;
        Job Job;
        public bool IsAdmin()
        {
           
        }
       
    }
    public class Admin : User
    {
 
        
    }
    public abstract class Job
    {
        public int GetMonthleyPay() // 
        {
            int Mounthpay;

            return Mounthpay;

        }
    }
    public class DailyPaidJob : Job
    {
        private int daylyPay()
        {
            
        }
    }
    public class HourleyPaidJob : Job
    {
        private int houtleyPay()
        {

        }
    }
    

}
