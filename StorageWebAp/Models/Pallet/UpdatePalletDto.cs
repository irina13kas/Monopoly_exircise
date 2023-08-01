using Application.Commands.PalletsCommands.UpdatePallet;
using Application.Common.Mappings;
using AutoMapper;

namespace StorageWebApi.Models.Pallet
{
    public class UpdatePalletDto : IMapWith<UpdatePalletCommand>
    {
        public int Id { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdatePalletDto, UpdatePalletCommand>()
                .ForMember(palletCommand => palletCommand.Id,
                    opt => opt.MapFrom(palletDto => palletDto.Id))
                .ForMember(palletCommand => palletCommand.Height,
                    opt => opt.MapFrom(palletDto => palletDto.Height))
                .ForMember(palletCommand => palletCommand.Width,
                    opt => opt.MapFrom(palletDto => palletDto.Width))
                .ForMember(palletCommand => palletCommand.Depth,
                    opt => opt.MapFrom(palletDto => palletDto.Depth));
        }
    }
}
