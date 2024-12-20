using AutoMapper;
using Contracts;
using SearchService.Models;

namespace SearchService.RequestHelpers;

public class MappingProfiles: Profile
{
    public MappingProfiles()
    {
        CreateMap<AuctionCreated,Item>().ReverseMap();
        CreateMap<AuctionUpdated,Item>().ReverseMap();
        CreateMap<AuctionDeleted,Item>().ReverseMap();
    }
}
