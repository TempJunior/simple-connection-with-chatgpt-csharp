using oop_2.domain.model;

namespace oop_2.domain.sdks.openai;
using OpenAI;
using OpenAI.Chat;
public class OpenAiConnection
{
    protected string languageName()
    {
        var lang = new Languages("Java", "Spring");
        return lang.Name;
    }
    public async Task RunChatConversation()
    {
        string key = "";

        //ChatClient client = new(model: "gpt-4o-mini", apiKey: key);

        //ChatCompletion completion = client.CompleteChat($"Faz um mini resumo da linguagem {languageName()}");
        //Console.WriteLine($"GPT >> {completion.Content[0].Text}");
    }
}