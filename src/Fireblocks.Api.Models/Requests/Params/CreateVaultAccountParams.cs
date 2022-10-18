namespace Fireblocks.Api.Models.Requests.Params;

public class CreateVaultAccountParams : BaseQueryParam
{
	/// <summary>
	/// The name of the new account (this can be renamed later)
	/// </summary>
	public string? name { get; set; }

	/// <summary>
	/// [optional] Should be set to true if you wish this account will not appear in the web console, false by default
	/// </summary>
	public bool? hiddenOnUI { get; set; }

	/// <summary>
	/// [optional] The ID for AML providers to associate the owner of funds with transactions
	/// </summary>
	public string? customerRefId { get; set; }

	/// <summary>
	/// [optional] In case the Gas Station service is enabled on your workspace<br/>
	/// this flag needs to be set to "true" if you wish to add this account's Ethereum address to be monitored and fueled upon detected deposits of ERC20 tokens.
	/// </summary>
	public bool? autoFuel { get; set; }
}
