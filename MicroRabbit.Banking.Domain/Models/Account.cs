﻿using System.ComponentModel.DataAnnotations;

namespace MicroRabbit.Banking.Domain.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string AccountType { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
