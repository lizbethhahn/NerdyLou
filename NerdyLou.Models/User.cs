namespace NerdyLou.Models
{
    public class User
    {
        public Guid UserId { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pronouns { get; set; } 
        public string Email { get; set; } 

        /* I'm assuming that Phone is a cell since this is likely
        for texting and/or push notifications.Correct formatting
        is required: area code - exchange - last four */
        public string Cell { get; set; }
        public UserRole Roles { get; set; } = UserRole.None;    
    }
}
