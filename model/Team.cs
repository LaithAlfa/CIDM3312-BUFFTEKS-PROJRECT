using System;

namespace Buffteks.Model
{
    public class Team
    {
        // PK
        public int TeamID {get; set;}
        // Student List - FK
        public Student StudentID {get; set;} 
        // Team Name
        public string TeamName {get; set;}
        // Projects - FK
        public project ProjectID {get;set;}
     }
}