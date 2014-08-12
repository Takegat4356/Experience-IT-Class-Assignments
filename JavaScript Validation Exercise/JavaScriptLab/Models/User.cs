using System.ComponentModel.DataAnnotations;
using Microsoft.SqlServer.Server;

namespace JavaScriptLab.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string WorkPhone { get; set; }
        public string CellPhone { get; set; }
        public string EmailAddress { get; set; }
        public string UserId { get; set; }
        
        public string Password { get; set; }
        public int YearsOfExperience { get; set; }
    }
}