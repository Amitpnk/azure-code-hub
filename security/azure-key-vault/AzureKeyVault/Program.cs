using AzureKeyVault;

var secretValue = await KeyVaultExample.GetSecretAsync("MySecret");
Console.WriteLine($"Retrieved Secret: {secretValue}");