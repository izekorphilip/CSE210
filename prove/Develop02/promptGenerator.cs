public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    // method
    public string GenerateRandomPrompt()
    {
        Random randomNum = new Random();
        int num = randomNum.Next(0, _prompts.Count);
        return _prompts[num];
    }
}