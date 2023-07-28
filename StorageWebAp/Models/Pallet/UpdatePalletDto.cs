﻿using Application.Commands.PalletsCommands;
using Application.Common.Mappings;
using AutoMapper;

namespace StorageWebApi.Models.Pallet
{
    public class UpdatePalletDto : IMapWith<UpdatePalletCommand>
    {
        public int Id { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdatePalletDto, UpdatePalletCommand>()
                .ForMember(palletCommand => palletCommand.PalletId,
                    opt => opt.MapFrom(palletDto => palletDto.Id))
                .ForMember(palletCommand => palletCommand.PalletHeight,
                    opt => opt.MapFrom(palletDto => palletDto.Height))
                .ForMember(palletCommand => palletCommand.PalletWidth,
                    opt => opt.MapFrom(palletDto => palletDto.Width))
                .ForMember(palletCommand => palletCommand.PalletDepth,
                    opt => opt.MapFrom(palletDto => palletDto.Depth));
        }
    }
}
