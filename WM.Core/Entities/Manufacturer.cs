namespace WM.Core.Entities
{
    public class Manufacturer : BaseEntity
    {
        public string Name { get; set; }
        public string AddressLine { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string ZipPostalCode { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
    }
}
