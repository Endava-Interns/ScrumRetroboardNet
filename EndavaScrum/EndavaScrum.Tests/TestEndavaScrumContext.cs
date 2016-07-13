using EndavaScrum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EndavaScrum.Tests
{
    public class TestEndavaScrumContext : IDbEntities
    {
        public TestEndavaScrumContext()
        {
            this.Sessions = new TestSessionDbSet();
        }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<User> Users { get; set; }

        public void Dispose() { }

        public void MarkAsModified(Session session){ }

        public int SaveChanges(){ return 0; }
    }
}
