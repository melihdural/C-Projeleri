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
        Console.WriteLine("[0] Average of Fibonacci Series");
        Console.WriteLine("[1] Create a Shape");
        Console.WriteLine("[2] Algorithm");
        Console.WriteLine("[3] Reverse Character Print");
        Console.WriteLine("[4] Calculate a Shape Area");
        
        Console.WriteLine("[Q] Quit");

        var input = Console.ReadLine();
        if (input is "Q" or "q")
        {
            Console.WriteLine("Good Bye!");
            return;
        }

        if (input != null) Program(input);
    }

    void Program(string input)
    {
        Shape? shape;
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
                
                shape = SelectShape.Select();
                if (shape != null) SelectShape.StartDrawProgram(shape);
                Select();
                break;

            case "2":
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
                
            case "3":
                Console.WriteLine("Reverse Character Printing");
                Console.WriteLine("Type a Sentence");
                var sentence = Console.ReadLine();

                Printer reversePrinter = new Printer();

                var newSentence = reversePrinter.Reverser(sentence);
                Console.WriteLine(newSentence);
                Console.WriteLine();
                Select();
                break;
            
            case "4":
                Console.WriteLine("Calculate Shapes Area");

                Console.WriteLine("What Calculation Did You Want?");
                Console.WriteLine("[1] Area");
                Console.WriteLine("[2] Perimeter");
                Console.WriteLine("[3] Volume");
                var calculation = Console.ReadLine();
                
                shape = SelectShape.Select();
                if (shape != null) SelectShape.StartCalculationProgram(shape, calculation);
                Select();
                break;
        }
    }
}