using DSharpPlus;
using DSharpPlus.EventArgs;
using Microsoft.Extensions.Logging;

namespace DiscordBot;

public class JBot
{

  public void Initialize(DiscordClient discord)
  {

    discord.MessageCreated += OnMessageCreated;

    discord.GuildAvailable += OnGuildAvailable;

    discord.ClientErrored += OnClientError;


  }

  private async Task OnClientError(DiscordClient client, ClientErrorEventArgs e)
  {
    client.Logger.LogError(e.Exception, "Error with client");
  }

  private async Task OnGuildAvailable(DiscordClient client, GuildCreateEventArgs e)
  {
    client.Logger.LogInformation(new EventId(1, "Guild Available"), null, $"Connected to server {e.Guild.Name}");

  }

  private async Task OnMessageCreated(DiscordClient client, MessageCreateEventArgs e)
  {
    Console.WriteLine("yoooooooooooooooooooooooooooooooo");
    Console.WriteLine(e);
    //   if (e.Message.get == ("ping"))
    //   {
    //     Console.WriteLine("beeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
    //     await e.Message.RespondAsync("pong!");
    //   }

    // }
  }
}