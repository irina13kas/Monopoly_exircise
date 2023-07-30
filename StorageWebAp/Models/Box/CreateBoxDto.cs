using Application.Commands.BoxesCommands;
using Application.Common.Mappings;
using AutoMapper;

namespace StorageWebApi.Models.Box
{
    public class CreateBoxDto : IMapWith<CreateBoxCommand>
    {
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal Weight { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public DateOnly? DateOfProduction { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateBoxDto, CreateBoxCommand>()
                .ForMember(boxCommand => boxCommand.BoxHeight,
                    opt => opt.MapFrom(boxDto => boxDto.Height))
                .ForMember(boxCommand => boxCommand.BoxWidth,
                    opt => opt.MapFrom(boxDto => boxDto.Height))
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
