using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CMCS_MVC_App.Models
{
    public class ApplicationUser : IdentityUser
    {
  

        //Attributes for each of the below properties are contained with Register.cshtml.cs

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string AccountHolderName { get; set; } = null!;
        public string AccountNumber { get; set; }


    }
}
