namespace StudentsSystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;

    using Models;

    public class StudentsSystemDbContext : IdentityDbContext<ApplicationUser>
    {
        public StudentsSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static StudentsSystemDbContext Create()
        {
            return new StudentsSystemDbContext();
        }
    }
}
