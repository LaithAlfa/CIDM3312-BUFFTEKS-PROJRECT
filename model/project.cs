using System;

namespace Buffteks.Model
{
    public class project
    {
         // PK
        public int ProjectID {get; set;}
        // name
        public char Project_Name {get; set;}
        // leader - FK team lead
        public Student StudentID {get; set;}
        // required hours
        public int Project_Hours{get; set;}
        // client - FK client
        public Client ClientID {get; set;}
        // deadline - DateTime
        public DateTime Deadline{get; set;}
    }
}