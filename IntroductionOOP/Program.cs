namespace IntroductionOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pigeon pippa = new Pigeon("Pippa", "Grey");
            pippa.Speak();
            pippa.Fly();
            pippa.EatPizza();
            pippa.Spin();
            pippa.DoTheCaterpillar();
            pippa.Jump();

            Penguin pingu = new Penguin("Pingu", "Black & White");
            pingu.Speak();
            pingu.Fly();
            pingu.Spin();
            pingu.DoTheCaterpillar();
            pingu.Jump();

            Parrot polly = new Parrot("Polly", "Green");
            polly.Speak();
            polly.Fly();
            polly.Spin();
            polly.DoTheCaterpillar();
            polly.Jump();

            Console.ReadKey();
        }
    }
}