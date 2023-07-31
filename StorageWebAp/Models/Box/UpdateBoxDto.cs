using Application.Commands.BoxesCommands.UpdateBox;
using Application.Common.Mappings;
using AutoMapper;

namespace StorageWebApi.Models.Box
{
    public class UpdateBoxDto : IMapWith<UpdateBoxCommand>
    {
        public int Id { get; set; }
        public int PalletId { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal Weight { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public DateOnly? DateOfProduction { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateBoxDto, UpdateBoxCommand>()
                .ForMember(boxCommand => boxCommand.BoxId,
                    opt => opt.MapFrom(boxDto => boxDto.Id))
                .ForMember(boxCommand => boxCommand.PalletId,
                    opt => opt.MapFrom(boxDto => boxDto.PalletId))
                .ForMember(boxCommand => boxCommand.BoxHeight,
                    opt => opt.MapFrom(boxDto => boxDto.Height))
                .ForMember(boxCommand => boxCommand.BoxWidth,
                    opt => opt.MapFrom(boxDto => boxDto.Width))
                .ForMember(boxCommand => boxCommand.BoxDepth,
                    opt => opt.MapFrom(boxDto => boxDto.Depth))
                .ForMember(boxCommand => boxCommand.BoxWeight,
                    opt => opt.MapFrom(boxDto => boxDto.Weight))
                .ForMember(boxCommand => boxCommand.BoxExpiryDate,
                    opt => opt.MapFrom(boxDto => boxDto.ExpiryDate))
                .ForMember(boxCommand => boxCommand.BoxDateOfProduction,
                    opt => opt.MapFrom(boxDto => boxDto.DateOfProduction));
        }
    }
}
