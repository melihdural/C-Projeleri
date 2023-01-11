namespace Net_BaslangicProjeleri.ConsonantCharacter;

public class CheckConsonant
{
    private static readonly char[] Vowels = new char[] {'a','e','ı','i','o','ö','u','ü','A','E','I','İ','O','Ö','U','Ü'};

    public void Check()
    {
        Console.WriteLine("Type a Sentence");
        var sentence = Console.ReadLine();
        var words = sentence.Split(' ');
        var wordsBool = new List<bool>();
        
        foreach (var word in words)
        {
            wordsBool.Add(false);

            for (var i = 0; i < word.Length - 1; i++)
            {
                var isVowel = Vowels.Any(x => x == word[i]);
                if (isVowel) continue;
                {
                    var isAfterCharIsVowel = Vowels.Any(x => x == word[i + 1]);
                    
                    if (isAfterCharIsVowel) continue;
                    wordsBool[^1] = true;
                    break;
                }
            }
            
        }
        
        foreach (var b in wordsBool)
        {
            Console.Write(b + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        
    }
}