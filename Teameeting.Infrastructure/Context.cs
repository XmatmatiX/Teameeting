using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teameeting.Domain.Model;

namespace Teameeting.Infrastructure
{
    public class Context : IdentityDbContext
    {

        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Meet> Meets { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberTeam> MemberTeam { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Team> Teams { get; set; }


        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<MemberTeam>()
                .HasKey(mt => new { mt.TeamId, mt.MemberId });

            builder.Entity<MemberTeam>()
                .HasOne<Member>(mt => mt.Member)
                .WithMany(m => m.MemberTeams)
                .HasForeignKey(mt => mt.MemberId);

            builder.Entity<MemberTeam>()
                .HasOne<Team>(mt => mt.Team)
                .WithMany(t => t.MemberTeams)
                .HasForeignKey(mt => mt.TeamId);
        }

    }
}
