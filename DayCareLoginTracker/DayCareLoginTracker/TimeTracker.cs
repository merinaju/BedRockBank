using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DayCareLoginTracker
{
    public class TimeTracker

    {
        #region Properties
        [Key]
        public int ID { get; set; }
        public string studentName { get; set; }
        public string ParentName { get; set; }
        public string Login { get; set; }
        public string Logout { get; set; }

        public virtual Student student { get; set; }

        #endregion

    }
}
