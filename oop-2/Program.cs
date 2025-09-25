using oop_2.domain.sdks.openai;

namespace oop_2;

internal class Program
{
    public static async Task Main(string[] args)
    {
        var ia = new OpenAiConnection();
        await ia.RunChatConversation();
    }
}