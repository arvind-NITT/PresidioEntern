﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PizzaShopAPI.models
{
    public class User
    {
        [Key]
        public int CustomerId { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordHashKey { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public string Status { get; set; }
        public int EmployeeId { get; internal set; }
    }
}
