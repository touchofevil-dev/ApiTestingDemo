﻿using System;

namespace ApiTesting.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int RollNo { get; set; }
    }
}
