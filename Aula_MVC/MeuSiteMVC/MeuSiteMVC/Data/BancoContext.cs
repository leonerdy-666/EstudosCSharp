using MeuSiteMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace MeuSiteMVC.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
            
        }

        public DbSet<ProdutoModel> Produtos { get; set; }
    }
}