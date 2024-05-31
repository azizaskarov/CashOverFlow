using CashOverFlow.Models.Reviews;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CashOverFlow.Brokers.Storages;

public partial class StorageBroker
{
    public DbSet<Review> Reviews { get; set; }

    public async ValueTask<Review> InsertReviewAsync(Review review) =>
        await InsertAsync(review);

    public IQueryable<Review> SelectAllReviews() => SelectAll<Review>();
}
