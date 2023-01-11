namespace Net_BaslangicProjeleri.Algorithm;

public class RemoveSelectedChar
{
    private string _newWord = String.Empty;
    
    public void Remove()
    {
        Console.WriteLine("Insert a Word");
        var word = Console.ReadLine();
        Console.WriteLine("Insert a char index that remove from your word");
        var order = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Your Word and Remove Order: {0},{1}", word,order);
        
        var charArray = word.ToCharArray();
        foreach (var c in charArray)
        {
            if (c != charArray[order])
                _newWord += c;
        }

        Console.WriteLine("Removed Word: {0}", _newWord);
        Console.WriteLine();
    }
}