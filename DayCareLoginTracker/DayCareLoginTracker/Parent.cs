using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DayCareLoginTracker
{
   public class Parent
    {
        #region Properties
        public string ParentName { get; set; }
        [Key]
        public string PhoneNumber { get; set; }
        public string streetAddress { get; set; }
        public string Email { get; set; }

        public virtual Student student { get; set; }
        #endregion


    }
}
