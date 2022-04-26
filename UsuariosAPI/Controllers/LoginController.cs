﻿using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Data.Requests;
using UsuariosAPI.Services;

namespace UsuariosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private LoginService _loginService;

        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult LogaUsuario(LoginRequest request)
        {
           Result result = _loginService.LogaUsuario(request);
            if (result.IsFailed) return Unauthorized(result.Reasons);
            //return Ok(result.Reasons.Select(c => c.Message));
            return Ok(result.Reasons);
        }

        [HttpPost("/solicita-reset")]
        public IActionResult SolicitaResetSenhaUsuario(SolicitaResetRequest request)
        {
            Result result = _loginService.SolicitaResetSenhaUsuario(request);
            if (result.IsFailed) return Unauthorized(result.Reasons);
            return Ok(result.Reasons);
        }

        [HttpPost("/efetua-reset")]
        public IActionResult ResetaSenhaUsuario(EfetuaResetRequest request)
        {
            Result result = _loginService.ResetaSenhaUsuario(request);
            if (result.IsFailed) return Unauthorized(result.Reasons);
            return Ok(result.Reasons);
        }
    }
}
