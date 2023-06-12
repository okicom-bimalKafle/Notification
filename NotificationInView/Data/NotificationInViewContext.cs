using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotificationInView.Models;

namespace NotificationInView.Data
{
    public class NotificationInViewContext : DbContext
    {
        public NotificationInViewContext (DbContextOptions<NotificationInViewContext> options)
            : base(options)
        {
        }

        public DbSet<NotificationInView.Models.UserModel> UserModel { get; set; } = default!;
    }
}
