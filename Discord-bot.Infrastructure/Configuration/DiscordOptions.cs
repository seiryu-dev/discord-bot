using dotenv.net;

namespace Discord_bot.infrastructure.Configuration;

public class DiscordOptions
{
    public readonly string Token;

    public DiscordOptions()
    {
        DotEnv.Load();
        var envVars = DotEnv.Read();
        Token = envVars["DISCORD_TOKEN"];
    }
}