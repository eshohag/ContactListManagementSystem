namespace ContactListApi.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("ContactListItems")]
    public class ContactListItem
    {
        [System.ComponentModel.DataAnnotations.Key]
        public long Id { get; set; }
        [System.ComponentModel.DisplayName("First Name")]
        public string FirstName { get; set; }
        [System.ComponentModel.DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [System.ComponentModel.DisplayName("Job Title")]
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
