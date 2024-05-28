﻿using Microsoft.AspNetCore.Mvc;
using Job_Portal_Application.Dto.AreasOfInterestDtos;
using Job_Portal_Application.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Job_Portal_Application.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Job_Portal_Application.Models;

namespace Job_Portal_Application.Controllers
{
    [ApiController]
    [Route("api/UserAreasOfInterest")]
    public class UserAreasOfInterestController : ControllerBase
    {
        private readonly IAreasOfInterestService _areasOfInterestService;

        public UserAreasOfInterestController(IAreasOfInterestService areasOfInterestService)
        {
            _areasOfInterestService = areasOfInterestService;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<AreasOfInterest>> AddAreaOfInterest([FromBody] AddAreasOfInterestDTO areasOfInterestDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                    var customErrorResponse = new
                    {
                        Title = "One or more validation errors occurred.",
                        Errors = errors
                    };


                    return BadRequest(customErrorResponse);
                }
                var addedAreaOfInterest = await _areasOfInterestService.AddAreasOfInterest(areasOfInterestDto);
                return Ok(addedAreaOfInterest);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<AreasOfInterest>> UpdateAreaOfInterest(AreasOfInterestDto areasOfInterestDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                var customErrorResponse = new
                {
                    Title = "One or more validation errors occurred.",
                    Errors = errors
                };


                return BadRequest(customErrorResponse);
            }
            try
            {
                var updatedAreaOfInterest = await _areasOfInterestService.UpdateAreasOfInterest(areasOfInterestDto);
                return Ok(updatedAreaOfInterest);
            }
            catch (AreasOfInterestNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpDelete("{areasOfInterestId}")]
        [Authorize]
        public async Task<ActionResult<bool>> DeleteAreaOfInterest(Guid areasOfInterestId)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                var customErrorResponse = new
                {
                    Title = "One or more validation errors occurred.",
                    Errors = errors
                };


                return BadRequest(customErrorResponse);
            }
            try
            {
                var result = await _areasOfInterestService.DeleteAreasOfInterest(areasOfInterestId);
                if (result)
                    return Ok(new { message = "Successfully deleted the area of interest" });

                return StatusCode(500, new { message = "Error deleting the area of interest" });
            }
            catch (AreasOfInterestNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpGet("{areasOfInterestId}")]
        [Authorize]
        public async Task<ActionResult<AreasOfInterestDto>> GetAreaOfInterest(Guid areasOfInterestId)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                var customErrorResponse = new
                {
                    Title = "One or more validation errors occurred.",
                    Errors = errors
                };


                return BadRequest(customErrorResponse);
            }
            try
            {
                var areasOfInterest = await _areasOfInterestService.GetAreasOfInterest(areasOfInterestId);
                return Ok(areasOfInterest);
            }
            catch (AreasOfInterestNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<AreasOfInterestDto>>> GetAllAreasOfInterest()
        {
            try
            {
                var areasOfInterest = await _areasOfInterestService.GetAllAreasOfInterest();
                return Ok(areasOfInterest);
            }
            catch (AreasOfInterestNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}
