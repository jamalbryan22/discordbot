using DiscordBot;
using DSharpPlus;

namespace FirstBot;

public static class DiscordExtensions
{

  private static JBot _Bot;

  public static DiscordClient AddJBot(this DiscordClient client)
  {

    _Bot = new JBot();
    _Bot.Initialize(client);

    return client;

  }

}