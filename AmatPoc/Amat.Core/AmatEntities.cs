using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Amat.Core
{
    public partial class AmatEntities : DbContext
    {
        public AmatEntities()
        : base( ConfigurationManager.ConnectionStrings["AmatEntities"].ToString() )
        {
            //disable initializer
        }
        public DbSet<CatalogItem> CatalogItems { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogItem>().ToTable("Catalog");
            base.OnModelCreating(modelBuilder);
        }
    }
    public abstract class BaseEntity
    {
        public virtual int Id { get; protected set; }
    }
    public class CatalogItem : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string PictureUri { get; private set; }
        public int CatalogTypeId { get; private set; }
        public int CatalogBrandId { get; private set; }
    }
}
