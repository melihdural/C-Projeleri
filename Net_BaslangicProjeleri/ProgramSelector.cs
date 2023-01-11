using Net_BaslangicProjeleri.Algorithm;
using Net_BaslangicProjeleri.AvarageOfFibonacciSeries;
using Net_BaslangicProjeleri.CalculationOfIntegers;
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
        Console.WriteLine("[5] Calculate Integers");
        
        Console.WriteLine("[Q] Quit");

        var input = Console.ReadLine();
        if (input is "Q" or "q")
        {
            Console.WriteLine("Good Bye!");
            return;
        }

        if (input != null) Program(input);
    }

    private void Program(string input)
    {
        Shape? shape;
        switch (input)
        {
            case "0":
                Console.WriteLine("Average of Fibonacci Series Project");
                var calculator = new AvarageCalculator();
                calculator.Avarage();
                
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
                
                var removeSelectedChar = new RemoveSelectedChar();
                removeSelectedChar.Remove();
                
                Select();
                break;
                
            case "3":
                Console.WriteLine("Reverse Character Printing");

                var reversePrinter = new Printer();
                reversePrinter.Reverser();
                
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
                if (shape != null)
                    if (calculation != null)
                        SelectShape.StartCalculationProgram(shape, calculation);
                Select();
                break;
            
            case "5":
                Console.WriteLine("Calculate Integer Pairs");

                var calculatePairs = new CalculatePairs();
                calculatePairs.Calculate();
                Select();
                break;
        }
    }
}