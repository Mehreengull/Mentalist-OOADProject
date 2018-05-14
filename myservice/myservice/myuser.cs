using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace myservice
{
    [DataContract]
    public class myuser
    {
        [DataMember]
        private string username;
        [DataMember]
        private string email;
        [DataMember]
        private int age;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public void setage(int s)
        {
            age = s;
        }
        public int getage()
        {
            return age;
        }
    }
}