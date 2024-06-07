using System;
using CashOverFlow.Brokers.Storages;
using CashOverFlow.Models.Locations;
using CashOverFlow.Services.Foundations.Locations;
using Moq;
using Tynamix.ObjectFiller;

namespace CashOverFlow.Tests.Unit.Services.Foundations.Locations;

public partial class LocationServiceTests
{
    private readonly Mock<IStorageBroker> storageBrokerMock;
    private readonly ILocationService locationService;

    public LocationServiceTests()
    {
        this.storageBrokerMock = new Mock<IStorageBroker>();

        this.locationService = new LocationService(
           storageBroker: storageBrokerMock.Object);
    }

    private DateTimeOffset GetRandomDatetimeOffset() => 
        new DateTimeRange(earliestDate: DateTime.UnixEpoch).GetValue();

    private Location CreateRandomLocation() =>
        CreateLocationFiller(GetRandomDatetimeOffset()).Create();

    private Filler<Location> CreateLocationFiller(DateTimeOffset dates)
    {
        var filler = new Filler<Location>();

        filler.Setup()
            .OnType<DateTimeOffset>().Use(dates);

        return filler;
    }

    
}
