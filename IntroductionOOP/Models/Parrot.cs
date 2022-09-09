namespace IntroductionOOP
{
    public class Parrot : Bird
    {
        public Parrot(string name, string color) : base(name, color) 
        {
        }
        public override void Speak()
        {
            Console.WriteLine($"Hi! I am {Name}. Never trust pigeons. Only parrots!");
        }
    }
}