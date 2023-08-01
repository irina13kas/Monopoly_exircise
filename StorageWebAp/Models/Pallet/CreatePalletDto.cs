using Application.Commands.PalletsCommands.CreatePallet;
using Application.Common.Mappings;
using AutoMapper;

namespace StorageWebApi.Models.Pallet
{
    public class CreatePalletDto : IMapWith<CreatePalletCommand>
    {
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreatePalletDto, CreatePalletCommand>()
                .ForMember(palletCommand => palletCommand.PalletHeight,
                    opt => opt.MapFrom(palletDto => palletDto.Height))
                .ForMember(palletCommand => palletCommand.PalletWidth,
                    opt => opt.MapFrom(palletDto => palletDto.Width))
                .ForMember(palletCommand => palletCommand.PalletDepth,
                    opt => opt.MapFrom(palletDto => palletDto.Depth));
        }
    }
}
