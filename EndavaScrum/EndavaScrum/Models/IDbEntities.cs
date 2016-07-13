using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndavaScrum.Models
{
    public interface IDbEntities : IDisposable
    {
        DbSet<Message> Messages { get; }
        DbSet<Session> Sessions { get; }
        DbSet<User> Users { get; }

        int SaveChanges();
        void MarkAsModified(Session session);
    }
}
