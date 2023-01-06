using Net_BaslangicProjeleri.Algorithm;
using Net_BaslangicProjeleri.AvarageOfFibonacciSeries;
using Net_BaslangicProjeleri.CreateShape;
using Net_BaslangicProjeleri.ReverseCharacterPrint;

namespace Net_BaslangicProjeleri;

public class ProgramSelector
{
    public void Select()
    {
        Console.WriteLine("Select a Project Which You Want");
        Console.WriteLine("[0] Avarage of Fibonacci Series");
        Console.WriteLine("[1] Create a Rectangle");
        Console.WriteLine("[2] Create a Circle");
        Console.WriteLine("[3] Algorithm");
        Console.WriteLine("[4] Reverse Character Print");
        Console.WriteLine("[Q] Quit");

        var input = Console.ReadLine();
        if (input == "Q" || input == "q")
        {
            Console.WriteLine("Good Bye!");
            return;
        }

        Program(input);
    }

    void Program(string input)
    {
        switch (input)
        {
            case "0":
                Console.WriteLine("Avarage of Fibonacci Series Project");
                AvarageCalculator calculator = new AvarageCalculator();
                var avarage = calculator.Avarage();
                Console.WriteLine();
                Console.WriteLine("Avarage of FibonacciSeries = {0}", avarage);
                Console.WriteLine();
                Select();
                break;
                
            case "1":
                Console.WriteLine("Draw Shapes");
                Shape rectangle = new Rectangle();
                Console.WriteLine("Insert a size for Rectangle");
                var size = Int32.Parse(Console.ReadLine());
                rectangle.Draw(size);
                Console.WriteLine();
                Select();
                break;
                
            case "2":
                Console.WriteLine("Insert a redius for Circle");
                var radius = Int32.Parse(Console.ReadLine());
                Shape circle = new Circle();
                circle.Draw(radius);
                Console.WriteLine();
                Select();
                break;
                
            case "3":
                Console.WriteLine("Algorithm");

                Console.WriteLine("Insert a Word");
                var word = Console.ReadLine();
                Console.WriteLine("Insert a char index that remove from your word");
                var order = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Your Word and Remove Order: {0},{1}", word,order);
                RemoveSelectedChar removeSelectedChar = new RemoveSelectedChar();
                var removedWord = removeSelectedChar.Remove(order, word);
                Console.WriteLine("Removed Word: {0}", removedWord);
                Console.WriteLine();
                Select();
                break;
                
            case "4":
                Console.WriteLine("Reverse Character Printing");
                Console.WriteLine("Type a Sentence");
                var sentence = Console.ReadLine();

                Printer reversePrinter = new Printer();

                var newSentence = reversePrinter.Reverser(sentence);
                Console.WriteLine(newSentence);
                Console.WriteLine();
                Select();
                break;
        }
    }
}