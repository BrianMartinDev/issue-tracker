using issue_tracker.Models.DTO.AppUser;
using issue_tracker.Services.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace issue_tracker.Controllers.ApiControllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
        {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtService _jwtService;
        private readonly ApiKeyService _apiKeyService;

        public UsersController(UserManager<IdentityUser> userManager, JwtService jwtService, ApiKeyService apiKeyService)
            {
            _userManager = userManager;
            _jwtService = jwtService;
            _apiKeyService = apiKeyService;
            }

        // GET: api/Users/username
        [HttpGet("{username}")]
        public async Task<ActionResult<LoginDTO>> GetUser(string username)
            {
            IdentityUser user = await _userManager.FindByNameAsync(username);

            if (user == null)
                {
                return NotFound();
                }

            return new AppUserDTO
                {
                UserName = user.UserName,
                Email = user.Email,
                };
            }

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<LoginDTO>> PostUser(LoginDTO user)
            {
            if (!ModelState.IsValid)
                {
                return BadRequest(ModelState);
                }
            var createUserProperties = new IdentityUser() { UserName = user.UserName, Email = user.Email };
            var password = user.Password;
            var result = await _userManager.CreateAsync(createUserProperties, password);

            if (!result.Succeeded)
                {
                return BadRequest(result.Errors);
                }

            user.Password = null;
            return CreatedAtAction("GetUser", new { username = user.UserName }, user);
            }

        // POST: api/Users/BearerToken
        [HttpPost("BearerToken")]
        public async Task<ActionResult<AuthRequestDTO>> CreateBearerToken(AuthRequestDTO request)
            {
            if (!ModelState.IsValid)
                {
                return BadRequest("Bad credentials");
                }

            var user = await _userManager.FindByNameAsync(request.UserName);

            if (user == null)
                {
                return BadRequest("Bad credentials");
                }

            var isPasswordValid = await _userManager.CheckPasswordAsync(user, request.Password);

            if (!isPasswordValid)
                {
                return BadRequest("Bad credentials");
                }

            var token = _jwtService.CreateToken(user);

            return Ok(token);
            }

        // POST: api/Users/ApiKey
        [HttpPost("ApiKey")]
        public async Task<ActionResult> CreateApiKey(AuthRequestDTO authRequest)
            {
            if (!ModelState.IsValid)
                {
                return BadRequest(ModelState);
                }

            var user = await _userManager.FindByNameAsync(authRequest.UserName);

            if (user == null)
                {
                return BadRequest("Bad credentials");
                }

            var isPasswordValid = await _userManager.CheckPasswordAsync(user, authRequest.Password);

            if (!isPasswordValid)
                {
                return BadRequest("Bad credentials");
                }

            var token = _apiKeyService.CreateApiKey(user);

            return Ok(token);
            }
        }
    }
