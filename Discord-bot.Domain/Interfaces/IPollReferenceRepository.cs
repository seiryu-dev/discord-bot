using Discord_bot.Domain.Entities;

namespace Discord_bot.Domain.Interfaces;

public interface IPollReferenceRepository
{
        Task SaveAsync(PollReference reference);
        Task<PollReference?> GetByDiscordPollIdAsync(string discordPollId);
}
