﻿using System;
using System.Threading.Tasks;
using CashOverFlow.Brokers.Storages;
using CashOverFlow.Models.Locations;

namespace CashOverFlow.Services.Foundations.Locations;

public class LocationService : ILocationService
{
    private IStorageBroker storageBroker;

    public LocationService(IStorageBroker storageBroker) => 
        this.storageBroker = storageBroker;

    public async ValueTask<Location> AddLocationAsync(Location location) =>
        await this.storageBroker.InsertLocationAsync(location);
}
