﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;
using NorthwindProject.Entities.Base;
using NorthwindProject.Entities.IBase;
using NorthwindProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindProject.WebAPI.Base
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme)]
    public class ApiBaseController<TInterface,T,TDto> : ControllerBase 
        where TInterface : IGenericService<T,TDto>
        where T:EntityBase where TDto : DtoBase
    {
        private readonly TInterface service;

        public ApiBaseController(TInterface service)
        {
            this.service = service;
        }

        [HttpGet("Find")]
        public IResponse<TDto> Find(int id)
        {
            try
            {
                var entity = service.Find(id);

                return entity;
                
            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    Message = $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }

        [HttpGet("GetAll")]
        public IResponse<List<TDto>> GetAll()
        {
            try
            {
                return service.GetAll();
            }
            catch (Exception ex)
            {
                return new Response<List<TDto>>
                {
                    Message = $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }


        [HttpPost("Add")]
        public IResponse<TDto> Add(TDto dto)
        {
            try
            {
                return service.Add(dto);
            }
            catch (Exception ex)
            {

                return new Response<TDto>
                {
                    Message = $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }



       
    }
}
