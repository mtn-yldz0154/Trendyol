using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EFCore
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-LM2N83TK;database=TrendyolDb;" +
                "integrated security=true;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products  { get; set; }
        public DbSet<Cart> Carts  { get; set; }
        public DbSet<Adress> Adresses  { get; set; }
        public DbSet<Order> Orders  { get; set; }
        public DbSet<OrderItem> OrderItems  { get; set; }
        public DbSet<Favori> Favoris  { get; set; }
        public DbSet<CartItem> CartItems  { get; set; }
        public DbSet<FavoriItem> FavoriItems  { get; set; }
        public DbSet<Comment> Comment  { get; set; }
        public DbSet<CommentLike> CommentLikes  { get; set; }
        public DbSet<Questions> Questions  { get; set; }
        public DbSet<AnswerQuestions> Answer  { get; set; }

    }
}
