namespace Fireblocks.Api.Models.Requests;

public class GetPublicKeyInfoForVaultAccountModel : BaseRequestModel
{
	/// <summary>
	/// Whether the returned key should be in compressed format or not, false by default
	/// </summary>
	public bool? Compressed { get; set; }
}
