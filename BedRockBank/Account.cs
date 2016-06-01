using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BedRockBank
{
   
     /// <summary> 
     /// Account type is an enum type for declaring an account as saving,checking ,CD 
  /// </summary 
 
    public enum AccountType
    {
        saving,checking,CD
    };

   /// <summary>
   /// This is the account class in BedrockBank         
   /// </summary>
                                                                                                                              
   public class Account
    {

        #region Variables
       private static int  lastAccountNumber = 0;
        #endregion

        

        #region Properties
        [Key]
        public int AccountNumber { get; private set; }
        [StringLength(10, ErrorMessage="Account name must be less than 10 characters in length")]
        public string AccountName { get; set; }
        public int SSN { get; set; }
        public double Balance { get; private set; }
        public AccountType TypeofAccount { get; set; }
        public virtual Customer customer { get; set; }

        #endregion

        #region Constructors
        public Account()
        {
            AccountNumber = ++lastAccountNumber;
        }
        #endregion

        #region Methods
        public double Deposit(double amount)
        {
            Balance = Balance + amount;
            return Balance;
        }
        #endregion
    }
}
                                                                   