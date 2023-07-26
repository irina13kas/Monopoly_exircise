using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Model.Interfaces
{
    public interface IPalletDbContext
    {
        DbSet<Pallet> Pallets { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
