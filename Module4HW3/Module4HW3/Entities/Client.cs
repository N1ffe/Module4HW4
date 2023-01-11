namespace Module4HW4.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string? CompanyName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Country { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>(); // 1 client has * projects
    }
}
