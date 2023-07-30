using Application.Common.Mappings;
using AutoMapper;

//2
namespace Application.Commands.Queries.GetPalletsList
{
    public class PalletVm : IMapWith<Pallet>
    {
        public ICollection<Box> Boxes { get; set; } = new List<Box>();
        public int Id { get; set; }

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public decimal Depth { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Pallet, PalletVm>()
                .ForMember(palletVm => palletVm.Height,
                    opt => opt.MapFrom(pallet => pallet.Height))
                .ForMember(palletVm => palletVm.Width,
                    opt => opt.MapFrom(pallet => pallet.Width))
                .ForMember(palletVm => palletVm.Depth,
                    opt => opt.MapFrom(pallet => pallet.Depth))
                .ForMember(palletVm => palletVm.Id,
                    opt => opt.MapFrom(pallet => pallet.Id));
        }
    }
}
