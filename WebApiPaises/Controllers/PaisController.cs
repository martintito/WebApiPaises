﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiPaises.Models;

namespace WebApiPaises.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        public readonly ApplicationDbContext context;
        public PaisController(ApplicationDbContext context)
        {
            this.context = context;
        }
        //listado de todos los paises: VERBO HTTP GET
        [HttpGet]
        public IEnumerable<Pais> Get()
        {
            return context.Paises.ToList();
        }
    }
}