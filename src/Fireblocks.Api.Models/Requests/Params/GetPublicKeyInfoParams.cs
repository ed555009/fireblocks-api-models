using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Requests.Params;

public class GetPublicKeyInfoParams : GetPublicKeyInfoForVaultAccountParams
{
	public SigningAlgorithm? algorithm { get; set; }
	public IEnumerable<int>? derivationPath { get; set; }
}
