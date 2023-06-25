using System;
using GameProject.Abstract;

namespace GameProject.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int BirthYear { get; internal set; }
        public int IdentityNumber { get; internal set; }
    }
}
