﻿using Job_Portal_Application.Dto.AreasOfInterestDtos;
using Job_Portal_Application.Dto.EducationDtos;
using Job_Portal_Application.Exceptions;
using Job_Portal_Application.Interfaces.IRepository;
using Job_Portal_Application.Interfaces.IService;
using Job_Portal_Application.Models;
using Job_Portal_Application.Repository.UserRepos;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Job_Portal_Application.Services.UsersServices
{
    public class AreasOfInterestService : IAreasOfInterestService
    {
        private readonly IAreasOfInterestRepository _areasOfInterestRepository;
        private readonly IAuthorizeService _authorizeService;
        private readonly IRepository<Guid, Title> _titleRepository;

        public AreasOfInterestService(IRepository<Guid, Title> titleRepository,IAreasOfInterestRepository areasOfInterestRepository, IAuthorizeService authorizeService)
        {
            _areasOfInterestRepository = areasOfInterestRepository;
            _authorizeService = authorizeService;
            _titleRepository = titleRepository;
        }

        public async Task<AreasOfInterest> AddAreasOfInterest(AddAreasOfInterestDTO areasOfInterestDto)
        {
            _ = await _titleRepository.Get(areasOfInterestDto.TitleId) ?? throw new TitleNotFoundException("Invalid TitleId. Title does not exist.");
          
            var areasOfInterest = new AreasOfInterest
            {
                UserId = _authorizeService.Gettoken(),
                TitleId = areasOfInterestDto.TitleId,
                Lpa = areasOfInterestDto.Lpa,
            };

            var addedAreasOfInterest = await _areasOfInterestRepository.Add(areasOfInterest);
            return addedAreasOfInterest;
        }

        public async Task<AreasOfInterest> UpdateAreasOfInterest(AreasOfInterestDto areasOfInterestDto)
        {
            var areasOfInterest = await _areasOfInterestRepository.Get(areasOfInterestDto.AreasOfInterestId, _authorizeService.Gettoken())
                                  ?? throw new AreasOfInterestNotFoundException("Areas of Interest record not found");

            areasOfInterest.TitleId = areasOfInterestDto.TitleId;
            areasOfInterest.Lpa = areasOfInterestDto.Lpa;

            return await _areasOfInterestRepository.Update(areasOfInterest);
        }

        public async Task<bool> DeleteAreasOfInterest(Guid areasOfInterestId)
        {
            var areasOfInterest = await _areasOfInterestRepository.Get(areasOfInterestId, _authorizeService.Gettoken())
                                  ?? throw new AreasOfInterestNotFoundException("Areas of Interest record not found");
            return await _areasOfInterestRepository.Delete(areasOfInterest);
        }

        public async Task<AreasOfInterest> GetAreasOfInterest(Guid areasOfInterestId)
        {
             return  await _areasOfInterestRepository.Get(areasOfInterestId, _authorizeService.Gettoken())
                                  ?? throw new AreasOfInterestNotFoundException("Areas of Interest record not found");


        }

        public async Task<IEnumerable<AreasOfInterest>> GetAllAreasOfInterest()
        {
            var areasOfInterests = await _areasOfInterestRepository.GetAll(_authorizeService.Gettoken());

            if (!areasOfInterests.Any())
            {
                throw new AreasOfInterestNotFoundException("Areas of Interest records not found");
            }

   

            return areasOfInterests;
        }
    }
}
