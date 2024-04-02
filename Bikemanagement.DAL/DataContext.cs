using BikeManagement.Domain.Models.Notifications;
using BikeManagement.Domain.Models.StatusManagements;
using BikeManagement.Domain.Models.UserManagements.Authentications;
using BikeManagement.Domain.Models.UserManagements.Complains;
using BikeManagement.Domain.Models.UserManagements.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeManagement.DAL
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Complain> Complains { get; set; }
        public DbSet<Complain_Reply> Complain_Replys { get; set; }
        public DbSet<UserAuthentication> UserAuthentications { get; set; }
        public DbSet<Status> Status { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Thiết lập khóa chính cho thực thể IdentityUserLogin<string>
            modelBuilder.Entity<IdentityUserLogin<string>>()
                .HasKey(l => l.UserId);

            //Xác định khóa chính
            modelBuilder.Entity<Status>()
                .HasKey(s => s.Status_Id);

            modelBuilder.Entity<Account>()
                .HasKey(u => u.Account_Id);

            modelBuilder.Entity<Role>()
                .HasKey(u => u.Role_Id);

            modelBuilder.Entity<User>()
                .HasKey(u => u.User_Id);

            modelBuilder.Entity<UserAuthentication>()
                .HasKey(u => u.UserAuthentication_Id);

            modelBuilder.Entity<Complain>()
                .HasKey(u => u.Complain_Id);

            modelBuilder.Entity<Complain_Reply>()
                .HasKey(u => u.Complain_Reply_Id);

            modelBuilder.Entity<Notification>()
                .HasKey(u => u.Notification_Id);



            //Set mối quan hệ
            modelBuilder.Entity<Account>()
                .HasOne(a => a.Status) // Mỗi Account chỉ có một Status
                .WithMany(s => s.Accounts) // Một Status có nhiều Accounts
                .HasForeignKey(a => a.Status_Id); // Sử dụng trường Status_Id trong Account làm khóa ngoại

            modelBuilder.Entity<Account>()
                .HasOne(a => a.Role) 
                .WithMany(s => s.Accounts) 
                .HasForeignKey(a => a.Role_Id);

            modelBuilder.Entity<Notification>()
                .HasOne(a => a.AccountSender)
                .WithMany(s => s.ReceivedNotifications)
                .HasForeignKey(a => a.Sender_Id);

            modelBuilder.Entity<Complain_Reply>()
                .HasOne(a => a.Account)
                .WithMany(s => s.Replys)
                .HasForeignKey(a => a.Account_Id);

            modelBuilder.Entity<Complain_Reply>()
                .HasOne(a => a.Complain)
                .WithMany(s => s.Replys)
                .HasForeignKey(a => a.Complain_Id)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Complain>()
                .HasOne(c => c.ComplainSender)
                .WithMany(a => a.ReceiverComplains)
                .HasForeignKey(c => c.Account_Id)
                .OnDelete(DeleteBehavior.Cascade); // Sử dụng Cascade để xóa các bản ghi con khi bản ghi cha bị xóa

        }



    }
}
