using System;

namespace Buffteks.Model
{
    public class Client
    {
        public project ProjectID {get; set;} 
        // PK
        public int ClientID {get; set;}
        // first name
        public char Client_FName{get; set;}
        // last name
        public char Client_LName{get; set;}
        // phone
        public int Client_Phone{get; set;}
        // email
        public string Client_Email{get; set;}
        // organization
        public string Client_Organization{get; set;}
    }
}