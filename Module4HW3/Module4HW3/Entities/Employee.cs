﻿namespace Module4HW4.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HiredDate { get; set; }
        public DateOnly? DateOfBirth { get; set; }

        // * employees belong to 1 office
        public int OfficeId { get; set; }
        public Office Office { get; set; }

        // * employees have 1 title
        public int TitleId { get; set; }
        public Title Title { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
