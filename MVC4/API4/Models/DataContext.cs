using System.Data.Entity;

namespace API4.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<API4.Models.Products> Products { get; set; }
    }
}