using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayCareLoginTracker
{
   public class DayCare
    {
        #region Variables
        public static DayCareModel db = new DayCareModel();
        #endregion
        public static Parent  FindParent(string emailaddress)
        {
            if(string.IsNullOrEmpty(emailaddress))
            {
                throw new  ArgumentNullException("Email address cannot be null or empty");
            }
            return db.Parents.Where(p => p.Email == emailaddress).FirstOrDefault();
        }

        public static Parent CreateParent(string parentname,string phonenumber,string streetaddress,string email)
        {
            var parent = new Parent() { ParentName = parentname, PhoneNumber = phonenumber, streetAddress = streetaddress, Email = email };
            db.Parents.Add(parent);
            db.SaveChanges();
            return parent;
        }

        public static Student RegisterStudent(string name,int age,Gender gender)
        {
            var student = new Student() { Name = name, Age = age, GenderType = gender };
            db.Students.Add(student);
            db.SaveChanges();
            return student;
        }
    }
}
