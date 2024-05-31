using CashOverFlow.Models.Reviews;
using System.Linq;
using System.Threading.Tasks;
namespace CashOverFlow.Brokers.Storages;

public partial interface IStorageBroker
{
    ValueTask<Review> InsertReviewAsync(Review review);
    IQueryable<Review> SelectAllReviews();
}
