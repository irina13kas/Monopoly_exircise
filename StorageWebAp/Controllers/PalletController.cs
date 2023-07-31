using Application.Commands.PalletsCommands;
using Application.Commands.PalletsCommands.CreatePallet;
using Application.Commands.PalletsCommands.UpdatePallet;
using Application.Commands.Vm.PalletVm;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using StorageWebApi.Models.Pallet;

namespace StorageWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PalletController: BaseController
    {
        private readonly IMapper _mapper;

        public PalletController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(ActionResult<PalletListVm>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PalletListVm>> GetAllPallets()
        {
            var query = new GetPalletListCommand();
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{limit, offset}")]
        [ProducesResponseType(typeof(ActionResult<PalletListVm>), StatusCodes.Status200OK)]
        public async Task<ActionResult<PalletListVm>> GetPalletsWithPagination(int limit, int offset)
        {
            var query = new GetPalletListWithPaginationCommand
            {
                Limit = limit,
                Offset = offset
            };
            var vm = await Mediator.Send(query);
            return Ok();
        } 

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ActionResult<PalletVm>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status410Gone)]
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
        [ProducesResponseType(typeof(ActionResult<int>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ActionResult<int>), StatusCodes.Status201Created)]
        public async Task<ActionResult<int>> CreatePallet([FromBody] CreatePalletDto createPalletDto)
        {
            var command = _mapper.Map<CreatePalletCommand>(createPalletDto);
            var palletId = await Mediator.Send(command);
            return Ok(palletId);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdatePallet([FromBody] UpdatePalletDto updatePalletDto)
        {
            var command = _mapper.Map<UpdatePalletCommand>(updatePalletDto);
            command.PalletId = PalletId;
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status410Gone)]
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
