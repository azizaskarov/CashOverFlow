﻿using System;
using System.Linq;
using System.Threading.Tasks;
using CashOverFlow.Models.Locations;
using Microsoft.EntityFrameworkCore;

namespace CashOverFlow.Brokers.Storages;

public partial class StorageBroker
{
    public DbSet<Location> Locations { get; set; }

    public async ValueTask<Location> InsertLocationAsync(Location location) =>
        await InsertAsync(location);

    public IQueryable<Location> SelectAllLocations() =>
        SelectAll<Location>();

    public async ValueTask<Location> SelectLocationByIdAsync(Guid id) =>
        await SelectAsync<Location>(id);

    public async ValueTask<Location> UpdateLocationAsync(Location location) =>
        await UpdateAsync(location);

    public async ValueTask<Location> DeleteLocationAsync(Location location) =>
        await DeleteAsync<Location>(location);
}
