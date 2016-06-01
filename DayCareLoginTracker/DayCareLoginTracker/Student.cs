using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace DayCareLoginTracker
{
    public enum Gender { male, female };
    public  class Student
    {
        #region Variables
        private static int lastStudentId = 0;
        #endregion

        #region properties
        public string Name { get; set; }
        public int Age { get; set; }
        [Key]
        public int StudentId { get; private set; }
        public Gender GenderType { get; set; }



        #region Constructor
        public Student()
        {
            StudentId = ++lastStudentId;
        }
        #endregion

        #endregion

    }
}
