using Models;

namespace Services;

public class HouseService
{
    private readonly List<House> _houses;

    public HouseService()
    {
        _houses =
        [
            new(new Guid("21fe027d-d06f-4fa2-bfd9-b6c3cb19edcd"), "Gryffindor"),
            new(new Guid("15270de9-18b1-41b2-b3ff-d73c5c553033"), "Ravenclaw"),
            new(new Guid("82d5aa20-3cbc-4d66-8f13-862a9fddccfb"), "Hufflepuff"),
            new(new Guid("4ca541c8-0ff0-4b21-8b07-ffb6ddd9b1d7"), "Slytherin")
        ];
    }

    public Task<IEnumerable<House>> GetHouses()
    {
        return Task.FromResult<IEnumerable<House>>(_houses);
    }
}