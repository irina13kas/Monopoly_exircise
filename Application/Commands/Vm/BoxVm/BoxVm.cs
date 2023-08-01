using Application.Common.Mappings;
using AutoMapper;

//2
namespace Application.Commands.Vm.BoxVm
{
    public class BoxVm : IMapWith<Box>
    {
        public int Id { get; set; }
        public int PalletId { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal Volume { get; set; }
        public decimal Weight { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public DateOnly? DateOfProduction { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Box, BoxVm>();
            profile.CreateMap<Box, BoxLookupDto>();
            profile.CreateMap<Box, BoxListVm>();
        }

    }
}
