using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new Mediator();

            var collegueA = new CollegueA(mediator);
            var collegueB = new CollegueB(mediator);

            mediator.Collegues.Add("A", collegueA);
            mediator.Collegues.Add("B", collegueB);


            collegueA.Send("hey everyone");

            var collegueC = new CollegueC(mediator);
            mediator.Collegues.Add("C", collegueC);

            collegueA.Send("Is there someone new?");

            Console.ReadLine();

        }
    }
}
