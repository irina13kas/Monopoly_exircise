using Application.Commands.PalletsCommands.GetListWithPagination;
using Application.Commands.PalletsCommands.CreatePallet;
using Application.Commands.PalletsCommands.UpdatePallet;
using Application.Commands.Vm.PalletVm;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StorageWebApi.Models.Pallet;
using Application.Commands.PalletsCommands.GetList;
using Application.Commands.PalletsCommands.GetDetails;
using Application.Commands.PalletsCommands.DeletePallet;

namespace StorageWebApi.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]")]
    public class PalletController: BaseController
    {
        private readonly IMapper _mapper;

        public PalletController(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// Get all exist pallets
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(ActionResult<PalletListVm>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PalletListVm>> GetAllPallets()
        {
            var query = new GetPalletListCommand();
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        /// <summary>
        /// Get list of pallets with pagination
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        [HttpGet("{limit} {offset}")]
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

        /// <summary>
        /// get information about some pallet
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// create new pallet
        /// </summary>
        /// <param name="createPalletDto"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(ActionResult<int>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ActionResult<int>), StatusCodes.Status201Created)]
        public async Task<ActionResult<int>> CreatePallet([FromBody] CreatePalletDto createPalletDto)
        {
            var command = _mapper.Map<CreatePalletCommand>(createPalletDto);
            var palletId = await Mediator.Send(command);
            return Ok(palletId);
        }

        /// <summary>
        /// update information about some pallet by id
        /// </summary>
        /// <param name="updatePalletDto"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdatePallet([FromBody] UpdatePalletDto updatePalletDto)
        {
            var command = _mapper.Map<UpdatePalletCommand>(updatePalletDto);
            await Mediator.Send(command);
            return Ok();
        }

        /// <summary>
        /// delete some pallet by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status410Gone)]
        public async Task<IActionResult> DeletePallet(int id)
        {
            var command = new DeletePalletCommand
            {
                Id = id
            };
            await Mediator.Send(command);
            return Ok();
        }
    }
}
