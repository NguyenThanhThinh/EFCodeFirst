﻿namespace One_to_Zero.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Address Address { get; set; }
    }
}
