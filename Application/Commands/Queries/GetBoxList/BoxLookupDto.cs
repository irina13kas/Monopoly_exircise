using Application.Common.Mappings;
using AutoMapper;

namespace Application.Commands.Queries.GetBoxList
{
    public class BoxLookupDto : IMapWith<Box>
    {
        public int Id { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Box, BoxLookupDto>()
                .ForMember(boxDto => boxDto.Id,
                    opt => opt.MapFrom(box => box.Id));
        }
    }
}
