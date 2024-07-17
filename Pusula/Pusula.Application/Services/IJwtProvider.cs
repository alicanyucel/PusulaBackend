using Pusula.Application.Features.Auth.Login;
using Pusula.Domain.Entities;

namespace Pusula.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
