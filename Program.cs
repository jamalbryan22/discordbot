using DSharpPlus;
using FirstBot;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

// class Program
// {
//   static void Main(string[] args)
//   {
//     MainAsync().GetAwaiter().GetResult();
//   }

//   static async Task MainAsync()
//   {
//     var discord = new DiscordClient(new DiscordConfiguration()
//     {
//       Token = "MTA1ODYwNzc5OTI2Mjc5MzgwOQ.GD4OiT.abyvmlDUS9_ijc_6bqFKUjoGRnSKUfgC_HwzuQ",
//       TokenType = TokenType.Bot
//     });

//     discord.MessageCreated += async (s, e) =>
//     {
//       if (e.Message.Content.ToLower().StartsWith("ping"))
//         await e.Message.RespondAsync("pong!");
//     };

//     await discord.ConnectAsync();
//     await Task.Delay(-1);
//   }
// }


var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", false)
    .AddUserSecrets(typeof(Program).Assembly, true)
    .AddEnvironmentVariables()
    .Build();

DiscordClient discord = new DiscordClient(new DiscordConfiguration
{
  AutoReconnect = true,
  MinimumLogLevel = Microsoft.Extensions.Logging.LogLevel.Debug,
  Intents = DiscordIntents.GuildMessages,
  Token = config["discordtoken"],
  TokenType = TokenType.Bot
});

discord.AddJBot();

await discord.ConnectAsync();
await Task.Delay(-1);