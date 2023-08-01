using Application.Common.Mappings;
using AutoMapper;

//2
namespace Application.Commands.Vm.PalletVm
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
            profile.CreateMap<Pallet, PalletVm>();
        }
    }
}
