﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WeRunApp.Entities
{
    [Table("Goals")]
    public class Goal
    {
        public int GoalId { get; set; }
        public int UserId { get; set; }
        public string GoalType { get; set; }
        public double GoalValue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsAchieved { get; set; }

        // relationship
        public User User { get; set; }
    }
}
