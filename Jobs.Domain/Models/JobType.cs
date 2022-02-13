﻿namespace Jobs.Domain.Models
{
    public class JobType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
