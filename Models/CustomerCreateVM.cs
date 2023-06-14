namespace customerManagement.Models
{
    public class CustomerCreateVM
    {
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; } 
        public long identityNumber { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public DateTime BirtDay { get; set; }
        public string Result { get; set; }
    }
}
