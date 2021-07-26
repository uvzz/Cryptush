using System;
using System.Security.Cryptography;

namespace Server
{
    class ServerRSAHandler
    {
        public static RSACryptoServiceProvider Create()
        {
            var rsa = new RSACryptoServiceProvider(2048);
            rsa.FromXmlString(@"<RSAKeyValue><Modulus>nGrA6vQNPnUxwO2pEgpvi9brj9CahBrTMotQvjfxa27bajIFOm/xvmzUILHbavJhBcqr7YJ5CLIs2jtT0EAJGr5EWe5ddTK0jRojkZmeyXcyb9KV8EXIxuQGhYvmAlD4LEuWd5LeSFizC/MkWTXHTRgba552UvjAcmfA9tl1RIHiLgZS4Ihir1/2IlB2MrH3txlzbMoS4y4/57cFOjGWHN+HPEHFSEqFdCAe19iopDxwDgNph0KcLEyqh2eoElt1ozjWbjyw0SE7/67Bu8Qv6Zz4E0j3QTapi2vtqnPSikzzpmW5t6ET5HDcZygP/Gr3Sy0QE9fXXxRrMSeZMVD2aQ==</Modulus><Exponent>AQAB</Exponent><P>zlqTAlT6CdnQUqddmT9a2Byuyv7mS6SBNXA8CcQIOcKIKCK24d9gxhvDNOoOEFfk7CIyB0+oB74y8ElXgnzqJ+zwklwG2k98b/wcPpTGAjhJMAgaZB0MB5Dt8pLBlVt2DQu/0lTAuLTnni7+wp2vuBuFw5jLKzT7JQcgfbSI4W8=</P><Q>wgyMhHKwnqAq5L66BG3Dmr9UWyrMmaoEPhMJvjnnL7B9P8BTiHGyRMI66NxDymCCXEnbgtRxQcIx/ka3sMC/LOvfUeWD+WgF+NS5AXCvOaYHW6EM2BkTESr8uxvModfS84PbBBbHuEPCXpi34kE/flW0zHRHEoMCAlnbsob3Cac=</Q><DP>ZOe3gWlqR0ziaLh8tYZcdtc3xf31QUH1CNuUEDZyy0PL7sxi33qqyNUklIhrTiScxbdG/Xo/MWIZaJSEnUNWASYE0Zz8oN5DfEMs0JFRbh51823S8eeeTUjagkavMMjjpid7qm9VOj0EEb7rRuFy3rVeqLHbj4o90PJ2OeIBGTM=</DP><DQ>K2mvTjpydSqULhTVfQQpjMddUgAjQgWdaV3NAjfmFu8/NjIK/i2hmmxxzYLpz68Duy3y5DQvGm0dzit4ER0uKBilH6dffT7ehyrgMQhKy3TvlHpVa0tAzsh1Pk8b2uF0GnLXXvTRvdG6/HriOMYsNFFsX4lsFSImIuyDkE9NmWU=</DQ><InverseQ>V7Mj7O2GiSXTC0KVTID+L6w7scSIjB4fE+Ma3pGIWQQke/XYXBhakMfiamSm64qZ+xQ0fU7sQNA2MZ2sTS3KwejYHPhX47uIpg6q0utb7mfeAGlvWHyOtNWYMaQ6Mw+cfXf4uxKGptWEfr2hkSK9tzClF++Zr15szVN8sJ0O5kI=</InverseQ><D>QNxjswoQk921C/OBMGHzb2FnvPMbn7wf582tZbN9ALevdJHZaSoSbIxkSkp2Whq38NbiBFMeLWT1BGmlj61+GQDdBw2442hrRjeYmD/DgHdVCtmgI0pMv2y+55HjhwJcZsHRWzQjyIw/cq0YXYXXZzif5jiHiFBuPQKZGcOCxS0QvBHogEcxeAKWtSY9YuaRKOhOkYuC8yor11q9sccfDi/M4An8RpdS1f6zwrjLmweAr8BtKYlxJqepYh/kEm7q+gQaqD35GS6rE7pN93M175l5O2lRToAvJFzMU4AasjKJEuJ+7ocox+xnvo4hhNBUYAwW2rgFxyv2itP1ajmNIQ==</D></RSAKeyValue>");
            return rsa;           
        }          
        public static string RSADecrypt(RSACryptoServiceProvider rsa, string key)
        {
            var encryptedKey = rsa.Decrypt(Convert.FromBase64String(key), false);
            return Convert.ToBase64String(encryptedKey);
        }
    }
}
