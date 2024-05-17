using CQRSMediaTr.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSMediaTr.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions): base(dbContextOptions) { }
       
        public DbSet<Employee> Employees { get; set; }
    }
}
