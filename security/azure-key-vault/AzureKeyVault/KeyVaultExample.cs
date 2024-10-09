using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System.Net;
using System.Text;
using Azure.Security.KeyVault.Keys;
using Azure.Security.KeyVault.Keys.Cryptography;

namespace AzureKeyVault;

internal class KeyVaultExample
{
    private const string keyVaultUrl = "https://<YourVaultName>.vault.azure.net/";

    public static async Task<string> GetSecretAsync(string secretName)
    {
        var client = new SecretClient(new Uri(keyVaultUrl), new DefaultAzureCredential());
        KeyVaultSecret secret = await client.GetSecretAsync(secretName);
        return secret.Value;
    }

    public static async Task UseKeyAsync()
    {
        var keyClient = new KeyClient(new Uri(keyVaultUrl), new DefaultAzureCredential());
        var cryptoClient = new CryptographyClient(new Uri($"{keyVaultUrl}/keys/MyKey"), new DefaultAzureCredential());

        // Encrypt a message
        byte[] plaintext = Encoding.UTF8.GetBytes("SensitiveData");
        EncryptResult encryptResult = await cryptoClient.EncryptAsync(EncryptionAlgorithm.RsaOaep, plaintext);

        // Decrypt the message
        DecryptResult decryptResult = await cryptoClient.DecryptAsync(EncryptionAlgorithm.RsaOaep, encryptResult.Ciphertext);
        string decryptedText = Encoding.UTF8.GetString(decryptResult.Plaintext);
        Console.WriteLine($"Decrypted Text: {decryptedText}");
    }
}

