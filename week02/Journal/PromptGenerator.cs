public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What are three things that went well today, and why?",
        "What were the highlights of my day?",
        "What are three things that I could have done differently today, and how can I learn from these experiences?",
        "What did I learn today?",
        "How did I show gratitude today?",
        "What were some challenges I faced today and how did I overcome them?",
        "What did I do to take care of myself today?",
        "What did I do to help others today?",
        "How did I prioritize my time today?",
        "What did I do to bring positivity into my day?",
        "What did I do today that made me proud of myself?",
        "What were the most important events of the day?",
        "How did I feel at different moments throughout the day?",
        "What were some unexpected events that took place today?",
        "Who did I interact with today and what were those interactions like?",
        "What did I accomplish today?",
        "What are some things I would like to do differently tomorrow?",
        "What did I do to relax and recharge today?",
        "What were some of the sights, sounds, and smells I experienced today?",
        "How did I handle any difficult situations that arose today?",
        "What are some things I am looking forward to tomorrow?",
        "What emotions did I experience today?",
        "How did I respond to each emotion? What triggered each emotion?",
        "What did I do to make a positive impact on someone else’s day?",
        "What am I looking forward to tomorrow?",
        "What can I do to prepare for a peaceful night’s sleep?",
        "What was the most significant event of my day and why was it important?",
        "How did I handle any conflicts or difficult situations today?",
        "What did I learn about myself today?",
        "What are some things I can do differently tomorrow to have an even better day?",
        "Who made a positive impact on my day and how?",
        "What did I do to make someone else’s day better?",
        "What are some things I want to remember about today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count());
        return _prompts[index];
    }
}