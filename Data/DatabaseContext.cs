using Microsoft.EntityFrameworkCore;

namespace RegisterApp.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options ) : base (options)
        {

        }

        public DbSet<Event> Events {get;set;}
        public DbSet<EventMember> EventMembers {get;set;}
        public DbSet<User> Users {get;set;}
    }
}