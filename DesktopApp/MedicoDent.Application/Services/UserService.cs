using AutoMapper;
using MedicoDent.Application.Abstractions;
using MedicoDent.Application.Requests;
using MedicoDent.Domain.Entities;
using System.Security.Cryptography;
using System.Text;

namespace MedicoDent.Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _repo;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<User> Authenticate(UserAuthenticationRequest request)
        {
            var user = await _repo.GetByUsernameAsync(request.Username ?? string.Empty);

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt ?? string.Empty, request.Password ?? string.Empty);

                if (newHash == user.PasswordHash)
                {
                    return _mapper.Map<User>(user);
                }
            }
            return new User();
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            new RNGCryptoServiceProvider().GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
