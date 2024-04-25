﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using Microsoft.FluentUI;

using Microsoft.Extensions.Hosting;

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
        public ICollection<Goal> Goals { get; set; } = new List<Goal>();
        public ICollection<Route> Routes { get; set; } = new List<Route>();
        public ICollection<RunHistory> RunHistory { get; set; } = new List<RunHistory>();

    }
   
}
