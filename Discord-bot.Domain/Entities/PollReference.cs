namespace Discord_bot.Domain.Entities;

public class PollReference
{
    public int Id { get; set; }
    public string DiscordPollId { get; set; }
    public string ChannelId { get; set; }


    public PollReference(string discordPollId, string channelId)
    {
        ChannelId = channelId;
        DiscordPollId = discordPollId;
    }
}