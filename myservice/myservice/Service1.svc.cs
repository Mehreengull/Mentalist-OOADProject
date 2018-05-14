using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace myservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool isvaliduser(string username, string email)
        {

            bool isFound = false;
            foreach (myuser u in userdl.users)
            {
                if (u.Username == username && u.Email == email)
                {
                    isFound = true;
                }

            }
            return isFound;

        }

        public void registration(string username, string email)
        {
            myuser u = new myuser();
            u.Username = username;
            u.Email = email;
       
            userdl.users.Add(u);
        }
        public int age()
        {
            int s = 0;
            foreach(myuser u in userdl.users)
            {
                s = u.getage();
            }
            return s;
        }

        string IService1.GetData(int value)
        {
            throw new NotImplementedException();
        }

        CompositeType IService1.GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }





        public void adminreg(string name, string password, string email)
        {
            admin a = new admin();
            a.Name = name;
            a.Password = password;
            a.Email = email;
            userdl.admins.Add(a);
            //function for admin registration
        }

        public bool isvalidadmin(string name, string email, string password)
        {

            bool isFound = false;
            foreach (admin a in userdl.admins)
            {
                if (a.Name == name && a.Email == email && a.Password == password)
                {
                    isFound = true;
                }

            }
            return isFound;
        }
    }
}
