

using Microsoft.EntityFrameworkCore;

using System;
using System.ComponentModel.DataAnnotations;

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
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Entered Email is not Valid!")]    
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string BankAccountNumber { get; set; }
    }
}
