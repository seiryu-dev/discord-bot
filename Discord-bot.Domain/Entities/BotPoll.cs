namespace Discord_bot.Domain.Entities;

public class BotPoll
{
    public string Question = "Kommst du heute zum Training?";
    public IReadOnlyList<string> Options = new List<string> { "Ja, ich komme zum Training!", "Nein, Ich komme nicht zum Training!" }.AsReadOnly();
}