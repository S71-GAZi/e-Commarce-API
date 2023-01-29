﻿using System.ComponentModel.DataAnnotations;

namespace e_Commarce_API.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
