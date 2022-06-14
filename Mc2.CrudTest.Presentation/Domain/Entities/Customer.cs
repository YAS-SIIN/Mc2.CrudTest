

using Microsoft.EntityFrameworkCore;

using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Presentation.Domain.Entities
{
    public class Customer : BaseEntity<int>
    {                                
        [Required]                                                                          
        [StringLength(100)]
        public string Firstname { get; set; }
                                
        [Required]
        [StringLength(100)]
        public string Lastname { get; set; }
                   
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(15)]                                       
        public ulong PhoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Entered Email is not Valid!")]    
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string BankAccountNumber { get; set; }

        public static explicit operator Customer(Task<Customer> v)
        {
            throw new NotImplementedException();
        }
    }
}
