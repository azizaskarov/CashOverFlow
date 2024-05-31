using System;
using System.Linq;
using System.Threading.Tasks;
using CashOverFlow.Models.Locations;

namespace CashOverFlow.Brokers.Storages;

public partial interface IStorageBroker
{
    ValueTask<Location> InsertLocationAsync(Location location);
    IQueryable<Location> SelectAllLocations();
    ValueTask<Location> SelectLocationByIdAsync(Guid Id);
    ValueTask<Location> UpdateLocationAsync(Location location);
    ValueTask<Location> DeleteLocationAsync(Location location);
}
