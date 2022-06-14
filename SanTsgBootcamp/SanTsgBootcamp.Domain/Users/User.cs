using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SanTsgBootcamp.Domain.Users
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "isim boş bırakılamaz")]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public bool Gender { get; set; }
        [Required]
        public bool Active { get; set; } = true;

        public DateTime CreatAt { get; set; } = DateTime.Now;
       
    }
}
