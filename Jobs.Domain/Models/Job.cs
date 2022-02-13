namespace Jobs.Domain.Models
{
    public class Job
    {
        //job info
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public DateTimeOffset PublishedAt { get; set; }
        public bool IsDelete { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }

        //business info
        public string BusinessName { get; set; }
        public string ContactName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string EmailToReceiveCV { get; set; }

        //relationship
        public int JobTypeId { get; set; }
        public JobType JobType { get; set; }
        
    }
}
