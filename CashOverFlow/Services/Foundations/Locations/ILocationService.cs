using System.Threading.Tasks;
using CashOverFlow.Models.Locations;

namespace CashOverFlow.Services.Foundations.Locations;

public interface ILocationService
{
    ValueTask<Location> AddLocationAsync(Location location);
}
