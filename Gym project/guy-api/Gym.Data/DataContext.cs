using Gym.Core.Entities;
using Gym.Core.Interface;
using Microsoft.EntityFrameworkCore;

namespace Gym.Data
{
    public class DataContext :DbContext, IDataContext
    {
        public DbSet<Trainer> ListTrainer { get; set; }
        public DbSet<Client> ListClient { get; set; }
        public DbSet<Lesson> ListLesson { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=GymDB");
        }

    }
}
