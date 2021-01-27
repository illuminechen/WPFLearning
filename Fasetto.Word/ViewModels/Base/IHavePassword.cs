using System.Security;

namespace Fasetto.Word
{
    /// <summary>
    /// An interface for a class that can provide a secure password
    /// </summary>
    public interface IHavePassword
    {
        SecureString SecurePassword { get; } 
    }
}
