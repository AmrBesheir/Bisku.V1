using System.ComponentModel.DataAnnotations;

namespace Bisku.Contracts.Authentication
{
	public class TokenRequestModel
	{
		[Required]
		public string Email { get; set; }

		[Required]
		public string Password { get; set; }
	}
}
