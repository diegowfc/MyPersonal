using Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.User
{
    public class User
    {
        public User(int id, string name, DateTime dateOfBirth, string email, string phoneNumber, int age, UserRole role)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNumber = phoneNumber;
            Age = age;
            Role = role;
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

         public string PhoneNumber { get; set; }

        public int Age { get; set; }

        public UserRole Role { get; set; }
    }
}
