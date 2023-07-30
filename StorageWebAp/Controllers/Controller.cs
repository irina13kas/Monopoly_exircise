using Application.Commands.BoxesCommands;
using Application.Commands.PalletsCommands;
using Application.Commands.Queries.GetBoxesList;
using Application.Commands.Queries.GetBoxList;
using Application.Commands.Queries.GetPallets;
using Application.Commands.Queries.GetPalletsList;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using StorageWebApi.Models.Box;
using StorageWebApi.Models.Pallet;
using System.Runtime.CompilerServices;

namespace StorageWebApi.Controllers
{
    [Route("api/[controller]")]

    public class Controller : BaseController
    {
        private readonly IMapper _mapper;

        public Controller(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<PalletListVm>> GetAllPallets()
        {
            var query = new GetPalletListQuery();
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet]
        public async Task<ActionResult<BoxListVm>> GetAllBoxes()
        {
            var query = new GetBoxListQuery
            {
                PalletId = PalletId
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PalletVm>> GetPallet(int id)
        {
            var query = new GetPalletDetailsQuery
            {
                Id = id
            };
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        [HttpGet("{id, palletId}")]
        public async Task<ActionResult<BoxVm>> GetBox(int id, int palletId)
        {
            var query = new GetBoxDetailsQuery
            {
                Id = id,
                PalletId = palletId
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

        [HttpPost]
        public async Task<ActionResult<int>> CreateBox([FromBody] CreateBoxDto createBoxDto)
        {
            var command = _mapper.Map<CreateBoxCommand>(createBoxDto);
            var boxId = await Mediator.Send(command);
            return Ok(boxId);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePallet([FromBody] UpdatePalletDto updatePalletDto)
        {
            var command = _mapper.Map<UpdatePalletCommand>(updatePalletDto);
            command.PalletId = PalletId;
            await Mediator.Send(command);
            return NoContent();
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
        public async Task<IActionResult> DeletePallet([FromBody] int id)
        {
            var command = new DeletePalletCommand
            {
                PalletId = id
            };
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
