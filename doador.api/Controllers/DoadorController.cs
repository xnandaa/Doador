﻿using doador.domain.Comamands;
using doador.domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace doador.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoadorController : ControllerBase
    {
        private readonly IDoadorService _doadorService;
        public DoadorController(IDoadorService doadorService)
        {
            _doadorService = doadorService;
        }

        [HttpPost]
        [Route("CadastrarDoador")]
        public async Task<IActionResult> PostAsync(DoadorCommand command)
        {
            return Ok(await _doadorService.PostAsync(command));
        }


    }
}