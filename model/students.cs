using System;

namespace Buffteks.Model
{
    public class Student
    {
         // PK
        public int StudentID {get; set;}
        // First name
        public char Student_FName{get; set;}
        // Last name
        public char Student_LName{get; set;}
        // Phone
        public int Student_Phone{get; set;}
        // Email
        public string Student_Email{get; set;}
        // Role
        public string Student_Role{get; set;}
    }
}