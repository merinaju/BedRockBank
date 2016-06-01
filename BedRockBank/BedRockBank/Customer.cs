﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BedRockBank
{
    public class Customer
    {
        [Key]
        public int CustomerID{ get; set; }
        public string  CustomerName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Account> Account { get; set; }

    }
}
