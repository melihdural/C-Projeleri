namespace Net_BaslangicProjeleri.Algorithm;

public class RemoveSelectedChar
{
    private string _newWord = String.Empty;
    
    public string Remove(int order, string word)
    {
        var charArray = word.ToCharArray();
        foreach (var c in charArray)
        {
            if (c != charArray[order])
                _newWord += c;
        }

        return _newWord;
    }
}