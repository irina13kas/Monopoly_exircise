using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Model.Interfaces
{
    public interface IBoxDbContext
    {
        DbSet<Box> Boxes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
