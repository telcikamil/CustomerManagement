namespace customerManagement.Models
{
    public class CompanyUpdateVM
    {
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public bool IsMernisRequired { get; set; }
    }
}
