namespace Bisku.Contracts.Authentication
{
	public class AuthModel
	{
		public string Message { get; set; } = string.Empty;
		public bool IsAuthenticated { get; set; }
		public string UserName { get; set; } = string.Empty;
		public string Email { get; set; }
		public List<string> Roles { get; set; }
		public string Token { get; set; } = string.Empty;
		public DateTime ExpiresOn { get; set; }
	}
}
