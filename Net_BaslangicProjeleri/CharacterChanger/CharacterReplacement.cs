namespace Net_BaslangicProjeleri.CharacterChanger;

public class CharacterReplacement
{
    private string _newSentences = string.Empty;
    public void Replace()
    {
        Console.WriteLine("Type a Sentence");
        var sentence = Console.ReadLine();
        
        var words = sentence.Split(' ');
        var newWord = string.Empty;
        
        foreach (var word in words)
        {
            var length = word.Length;
            for (var i = 0; i < word.Length; i++)
            {
                if (i == 0)
                {
                    newWord += word[length - 1];
                }
                else if (i == length -1)
                {
                    newWord += word[0];
                }
                else
                {
                    newWord += word[i];
                }
            }

            newWord += ' ';
        }

        _newSentences += newWord;
        
        Console.WriteLine("New sentence with replaced character = {0}",_newSentences);
        Console.WriteLine();
    }
}