namespace NorthWindDomain.Entities
{
    public class StudentAddress
    {
        public int StudentAddressId { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual Student Student { get; set; }
    }
}
