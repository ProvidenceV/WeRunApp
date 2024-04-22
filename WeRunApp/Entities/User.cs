using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace WeRunApp.Entities
{
    [Table("Users")]
    public class User
    {
        uint Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? FirstName { get; set; }    
        public string? LastName { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }

    }
   
}
