using Application.Commands.BoxesCommands.CreateBox;
using Application.Commands.BoxesCommands.DeleteBox;
using Application.Commands.BoxesCommands.GetDetails;
using Application.Commands.BoxesCommands.GetList;
using Application.Commands.BoxesCommands.UpdateBox;
using Application.Commands.Vm.BoxVm;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StorageWebApi.Models.Box;

namespace StorageWebApi.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]")]
    public class BoxController : BaseController
    {
        private readonly IMapper _mapper;

        public BoxController(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// get all boxes in pallet
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(ActionResult<BoxListVm>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<BoxListVm>> GetAllBoxes()
        {
            var query = new GetBoxListCommand
            {
                PalletId = PalletId
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        /// <summary>
        /// get information about some box by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="palletId"></param>
        /// <returns></returns>
        [HttpGet("{id} {palletId}")]
        [ProducesResponseType(typeof(ActionResult<BoxVm>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status410Gone)]
        public async Task<ActionResult<BoxVm>> GetBox(int id, int palletId)
        {
            var query = new GetBoxDetailsCommand
            {
                Id = id,
                PalletId = palletId
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        /// <summary>
        /// create box in some pallet
        /// </summary>
        /// <param name="createBoxDto"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(ActionResult<int>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ActionResult<int>), StatusCodes.Status201Created)]
        public async Task<ActionResult<int>> CreateBox([FromBody] CreateBoxDto createBoxDto)
        {
            var command = _mapper.Map<CreateBoxCommand>(createBoxDto);
            var boxId = await Mediator.Send(command);
            return Ok(boxId);
        }

        /// <summary>
        /// update information about some box by id
        /// </summary>
        /// <param name="updateBoxDto"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateBox([FromBody] UpdateBoxDto updateBoxDto)
        {
            var command = _mapper.Map<UpdateBoxCommand>(updateBoxDto);
            command.BoxId = BoxId;
            await Mediator.Send(command);
            return NoContent();
        }

        /// <summary>
        /// delete box by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status410Gone)]
        public async Task<IActionResult> DeleteBox([FromBody] int id)
        {
            var command = new DeleteBoxCommand
            {
                BoxId = id
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
