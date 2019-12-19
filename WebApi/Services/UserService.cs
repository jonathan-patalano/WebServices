using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.IServices;

namespace WebApi.Services
{
    public class UserService : IUserService
    {
        #region Propri�t�s

        // Utilisateurs cod�s en dur pour plus de simplicit�
        // Stock�s dans une base de donn�es avec des mots de passe hach�s dans les applications de production.
        private List<User> _users = new List<User>
        { 
            new User { Id = 1, FirstName = "Jonathan", LastName = "Patalano", Username = "jopatalano", Password = "azerty" } 
        };

        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        #endregion

        /// <summary>
        /// Authentification d'un utilisateur.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User Authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);

            // Retourne null si l'utilisateur n'a pas �t� trouv�e.
            if (user == null)
                return null;

            // Authentification r�ussie donc g�n�re un token jwt.
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] 
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            return user.WithoutPassword();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAll()
        {
            return _users.WithoutPasswords();
        }
    }
}