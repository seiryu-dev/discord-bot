using dotenv.net;

namespace Discord_bot.infrastructure.Configuration;

public class DiscordConfigurations
{
    public string Token { get; }
    public ulong GuildId { get; }
    public ulong ChannelId { get; }

    public DiscordConfigurations()
    {
        DotEnv.Load();
        var envVars = DotEnv.Read();
        Token = envVars["DISCORD_TOKEN"];
        GuildId = Convert.ToUInt64(envVars["DISCORD_GUILD_ID"]);
        ChannelId = Convert.ToUInt64(envVars["DISCORD_CHANNEL_ID"]);
    }
}