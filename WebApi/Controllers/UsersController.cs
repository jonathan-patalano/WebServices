using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApi.Models;
using WebApi.IServices;

namespace WebApi.Controllers
{
    /// <summary>
    /// Controller des méthodes concernant les utilisateurs.
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        #region Propriétés

        private IUserService _userService;

        #endregion

        #region Constructeur

        /// <summary>
        /// Constructeur du controller
        /// </summary>
        /// <param name="userService"></param>
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        #region Méthodes publiques

        /// <summary>
        /// Authentification d'un utilisateur.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateModel model)
        {
            var user = _userService.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Identifiant ou Mot de passe incorrect" });

            return Ok(user);
        }

        /// <summary>
        /// Récuperation de tous les utilisateurs.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        #endregion
    }
}
