﻿using System.ComponentModel.DataAnnotations;

namespace ChainOfRespProject.DAL
{
    public class CustomerProcess
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string EmployeeName { get; set; }
        public string Description { get; set; }

    }
}
