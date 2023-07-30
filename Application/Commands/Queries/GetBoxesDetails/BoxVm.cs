using Application.Common.Mappings;
using AutoMapper;

//2
namespace Application.Commands.Queries.GetBoxesList
{
    public class BoxVm : IMapWith<Box>
    {
        public int Id { get; set; }
        public int PalletId { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set;}
        public decimal Volume { get; set; }
        public decimal Weight { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public DateOnly? DateOfProduction { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<BoxVm, Box>()
                .ForMember(boxVm => boxVm.Id,
                    opt => opt.MapFrom(box => box.Id))
                //2
                //.ForMember(boxVm => boxVm.PalletId,
                //    opt => opt.MapFrom(box => box.PalletId))
                .ForMember(boxVm => boxVm.Height,
                    opt => opt.MapFrom(box => box.Height))
                .ForMember(boxVm => boxVm.Width,
                    opt => opt.MapFrom(box => box.Width))
                .ForMember(boxVm => boxVm.Depth,
                    opt => opt.MapFrom(box => box.Depth))
                .ForMember(boxVm => boxVm.Volume,
                    opt => opt.MapFrom(box => box.Volume))
                .ForMember(boxVm => boxVm.Weight,
                    opt => opt.MapFrom(box => box.Weight))
                .ForMember(boxVm => boxVm.ExpiryDate,
                    opt => opt.MapFrom(box => box.ExpiryDate))
                .ForMember(boxVm => boxVm.ExpiryDate,
                    opt => opt.MapFrom(box => box.ExpiryDate))
                .ForMember(boxVm => boxVm.DateOfProduction,
                    opt => opt.MapFrom(box => box.DateOfProduction));
        }

    }
}
