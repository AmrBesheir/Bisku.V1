namespace Bisku.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController(IAuthService authService) : ControllerBase
	{
		private readonly IAuthService _authService = authService;
		[HttpPost("register")]
		public async Task<IActionResult> RegisterAsync([FromBody] RegisterModel model, CancellationToken cancellationToken)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);
			var result = await _authService.RegisterAsync(model);
			if (!result.IsAuthenticated)
				return BadRequest(result.Message);

			return Ok(result);
		}

		[HttpPost("login")]

		public async Task<IActionResult> LoginAsync([FromBody] TokenRequestModel model, CancellationToken cancellationToken)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);
			var result = await _authService.GetTokenAsync(model);
			if (!result.IsAuthenticated)
				return BadRequest(result.Message);

			return Ok(result);
		}

		[HttpPost("addRole")]
		public async Task<IActionResult> AddRoleASync(AddRoleModel model, CancellationToken cancellationToken)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);
			var result = await _authService.AddRoleAsync(model);
			if (!string.IsNullOrEmpty(result))
				return BadRequest(result);

			return Ok(model);

		}
	}
}
