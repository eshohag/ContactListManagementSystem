namespace ContactListApi.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("ContactListItems")]
    public class ContactListItem
    {
        [System.ComponentModel.DataAnnotations.Key]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
