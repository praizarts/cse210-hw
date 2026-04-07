
class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
        "This activity will help you relax by guiding your breathing slowly.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            BreatheIn();
            BreatheOut();
            elapsed += 10; 
        }

        DisplayEndingMessage();
    }

    private void BreatheIn()
    {
        Console.WriteLine("\nBreathe in...");
        AnimateBreath(true);
    }

    private void BreatheOut()
    {
        Console.WriteLine("\nBreathe out...");
        AnimateBreath(false);
    }

    private void AnimateBreath(bool isInhaling)
    {
        int maxSize = 20;

        if (isInhaling)
        {
            for (int i = 1; i <= maxSize; i++)
            {
                Console.Clear();
                Console.WriteLine("Breathe in...\n");

                Console.WriteLine(new string('O', i));

                int delay = 20 + (i * 15);
                Thread.Sleep(delay);
            }
        }
        else
        {
            for (int i = maxSize; i >= 1; i--)
            {
                Console.Clear();
                Console.WriteLine("Breathe out...\n");

                Console.WriteLine(new string('O', i));

                int delay = 20 + ((maxSize - i) * 15);
                Thread.Sleep(delay);
            }
        }
    }
}
