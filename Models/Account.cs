using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string OwnerName { get; set; }
        public double Balance { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
