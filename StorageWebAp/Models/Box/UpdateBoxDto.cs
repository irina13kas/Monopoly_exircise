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
                .ForMember(boxCommand => boxCommand.Id,
                    opt => opt.MapFrom(boxDto => boxDto.Id))
                .ForMember(boxCommand => boxCommand.PalletId,
                    opt => opt.MapFrom(boxDto => boxDto.PalletId))
                .ForMember(boxCommand => boxCommand.Height,
                    opt => opt.MapFrom(boxDto => boxDto.Height))
                .ForMember(boxCommand => boxCommand.Width,
                    opt => opt.MapFrom(boxDto => boxDto.Width))
                .ForMember(boxCommand => boxCommand.Depth,
                    opt => opt.MapFrom(boxDto => boxDto.Depth))
                .ForMember(boxCommand => boxCommand.Weight,
                    opt => opt.MapFrom(boxDto => boxDto.Weight))
                .ForMember(boxCommand => boxCommand.ExpiryDate,
                    opt => opt.MapFrom(boxDto => boxDto.ExpiryDate))
                .ForMember(boxCommand => boxCommand.DateOfProduction,
                    opt => opt.MapFrom(boxDto => boxDto.DateOfProduction));
        }
    }
}
