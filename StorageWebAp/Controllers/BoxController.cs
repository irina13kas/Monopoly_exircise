using Application.Commands.BoxesCommands;
using Application.Commands.Vm.BoxVm;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StorageWebApi.Models.Box;

namespace StorageWebApi.Controllers
{
    [Route("api/[controller]")]

    public class BoxController : BaseController
    {
        private readonly IMapper _mapper;

        public BoxController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<BoxListVm>> GetAllBoxes()
        {
            var query = new GetBoxListCommand
            {
                PalletId = PalletId
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id, palletId}")]
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

        [HttpPost]
        public async Task<ActionResult<int>> CreateBox([FromBody] CreateBoxDto createBoxDto)
        {
            var command = _mapper.Map<CreateBoxCommand>(createBoxDto);
            var boxId = await Mediator.Send(command);
            return Ok(boxId);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBox([FromBody] UpdateBoxDto updateBoxDto)
        {
            var command = _mapper.Map<UpdateBoxCommand>(updateBoxDto);
            command.BoxId = BoxId;
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
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
