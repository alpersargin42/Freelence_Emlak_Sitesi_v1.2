using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-A98FCNP;database=Trkmn_Gr;integrated security=true;");
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message2>().HasOne(x => x.SenderUser).WithMany(y => y.AdvertiserSender)
                .HasForeignKey(z => z.SenderID).OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Message2>().HasOne(x => x.ReceiverUser).WithMany(y => y.AdvertiserReceiver)
                .HasForeignKey(z => z.ReceiverID).OnDelete(DeleteBehavior.ClientSetNull);

            //HomeMatches ---->AdvertiserSender
            //AwayMatches ---->AdvertiserReceiver

            //HomeTeam ------> SenderUser
            //GuestTeam ------> ReceiverUser
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<About> Abouts { get; set; }
		public DbSet<Estate> Estates { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Advertiser> Advertisers { get; set; }
		public DbSet<EstateRaytings> EstateRaytings { get; set; }
		public DbSet<Message2> Messages2 { get; set; }
    }
}
