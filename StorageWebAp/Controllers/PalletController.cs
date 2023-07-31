using Application.Commands.PalletsCommands;
using Application.Commands.Vm.PalletVm;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StorageWebApi.Models.Pallet;

namespace StorageWebApi.Controllers
{
    [Route("api/[controller]")]
    public class PalletController: BaseController
    {
        private readonly IMapper _mapper;

        public PalletController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<PalletListVm>> GetAllPallets()
        {
            var query = new GetPalletListCommand();
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PalletVm>> GetPallet(int id)
        {
            var query = new GetPalletDetailsCommand
            {
                Id = id
            };
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreatePallet([FromBody] CreatePalletDto createPalletDto)
        {
            var command = _mapper.Map<CreatePalletCommand>(createPalletDto);
            var palletId = await Mediator.Send(command);
            return Ok(palletId);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePallet([FromBody] UpdatePalletDto updatePalletDto)
        {
            var command = _mapper.Map<UpdatePalletCommand>(updatePalletDto);
            command.PalletId = PalletId;
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePallet([FromBody] int id)
        {
            var command = new DeletePalletCommand
            {
                PalletId = id
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
