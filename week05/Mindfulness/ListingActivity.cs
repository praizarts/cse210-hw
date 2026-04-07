class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who do you appreciate?",
        "What are your strengths?",
        "Who did you help recently?",
        "When did you feel peace?",
        "Who are your heroes?"
    };

    private int _count;

    public ListingActivity()
        : base("Listing Activity",
        "List as many positive things as you can.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);

        Console.WriteLine("\nYou may begin in:");
        ShowCountDown(5);

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        _count = items.Count;

        Console.WriteLine($"\nYou listed {_count} items!");

        DisplayEndingMessage();
    }
}
