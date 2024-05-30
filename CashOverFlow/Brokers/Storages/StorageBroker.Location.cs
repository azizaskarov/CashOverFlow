using CashOverFlow.Models.Locations;
using Microsoft.EntityFrameworkCore;

namespace CashOverFlow.Brokers.Storages;

public partial class StorageBroker
{
    public DbSet<Location> Locations { get; set; }
}
