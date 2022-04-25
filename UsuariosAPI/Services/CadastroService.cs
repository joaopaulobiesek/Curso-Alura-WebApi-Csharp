using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System.Web;
using UsuariosAPI.Data.Dtos;
using UsuariosAPI.Data.Requests;
using UsuariosAPI.Models;

namespace UsuariosAPI.Services
{
    public class CadastroService
    {
        private IMapper _mapper;
        private UserManager<IdentityUser<int>> _userManager;
        private EmailService _emailService;

        public CadastroService(IMapper mapper, UserManager<IdentityUser<int>> userManager, EmailService emailService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _emailService = emailService;
        }

        public Result CadastraUsuario(CreateUsuarioDto createDto)
        {
            Usuario usuario = _mapper.Map<Usuario>(createDto);
            IdentityUser<int> identityUser = _mapper.Map<IdentityUser<int>>(usuario);
            var resultadoIdentity = _userManager.CreateAsync(identityUser, createDto.Password);
            if (resultadoIdentity.Result.Succeeded)
            {
                var code = _userManager.GenerateEmailConfirmationTokenAsync(identityUser).Result;
                var encodeCode = HttpUtility.UrlEncode(code);
                _emailService.EnviarEmail(new[] { identityUser.Email}, "Link de Ativação", identityUser.Id, encodeCode);
                return Result.Ok().WithSuccess(code);
            }
            return Result.Fail("Falha ao cadastrar Usuário");
        }

        public Result AtivaContaUsuario(AtivaContaRequest request)
        {
            var identityUser = _userManager.Users.FirstOrDefault(u => u.Id == request.UserId);
            var identityResult = _userManager.ConfirmEmailAsync(identityUser, request.CodigoDeAtivacao).Result;
            if (identityResult.Succeeded)
            {
                return Result.Ok();
            }
            return Result.Fail("Falha ao ativar conta de usuário");
        }
    }
}