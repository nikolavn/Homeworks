namespace StudentSystem.Web.Models
{
    using System;

    public class CoursesRequestModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}