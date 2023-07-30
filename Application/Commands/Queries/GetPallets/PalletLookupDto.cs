using Application.Common.Mappings;
using AutoMapper;

namespace Application.Commands.Queries.GetPallets
{
    public class PalletLookupDto : IMapWith<Pallet>
    {
        public int Id { get; set; }
        public List<Box> Boxes { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Pallet, PalletLookupDto>()
                .ForMember(palletDto => palletDto.Id,
                    opt => opt.MapFrom(pallet => pallet.Id))
                .ForMember(palletDto => palletDto.Boxes,
                    opt => opt.MapFrom(pallet => pallet.Boxes));
        }
    }
}
