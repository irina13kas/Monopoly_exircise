using Application.Commands.BoxesCommands.CreateBox;
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
                .ForMember(boxCommand => boxCommand.Height,
                    opt => opt.MapFrom(boxDto => boxDto.Height))
                .ForMember(boxCommand => boxCommand.Width,
                    opt => opt.MapFrom(boxDto => boxDto.Height))
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
