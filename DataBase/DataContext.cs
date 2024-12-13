using Microsoft.EntityFrameworkCore;
using PTPDelivery.Server.Models;
using PTPDelivery.Server.Models.Carrier;
using PTPDelivery.Server.Models.Sender;

namespace PTPDelivery.Server.DataBase
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        #region Principale Enteties

        public DbSet<Carrier> carriers { get; set; }
        public DbSet<Sender> senders { get; set; }

        #endregion

        #region Carrier Region
        public DbSet<Trip> trip { get; set; }
        public DbSet<Document> documents { get; set; }

        #endregion

        #region Commun
        public DbSet<Payment> payments { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<Item> items { get; set; }

        #endregion

    }
}
