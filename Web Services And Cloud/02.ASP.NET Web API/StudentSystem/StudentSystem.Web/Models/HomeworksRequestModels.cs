namespace StudentSystem.Web.Models
{
    using System;

    public class HomeworksRequestModels
    {
        public int Id { get; set; }

        public string FileUrl { get; set; }

        public DateTime TimeSent { get; set; }

        public int StudentIdentification { get; set; }

        public Guid CourseId { get; set; }
    }
}