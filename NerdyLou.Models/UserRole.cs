namespace NerdyLou.Models
{
    [Flags]
    public enum UserRole
    {
        /* Left-shift operator makes for easier combination roles like Admin and Leader: 
           UserRole userPermissions = UserRole.TechVolunteer | UserRole.Admin; */

        None = 0,
        MiscVolunteer = 1 << 0,
        GMVolunteer = 1 << 1,
        TechVolunteer = 1 << 2,
        Leader = 1 << 3,
        Admin = 1 << 4
    }
}
