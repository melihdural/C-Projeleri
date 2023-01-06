namespace Net_BaslangicProjeleri.ReverseCharacterPrint;

public class Printer
{
    string _newWord = String.Empty;
    public string Reverser(string sentence)
    {
        var charArray = sentence.Split(' ');
        foreach (var s in charArray)
        {
            s.ToCharArray();
            for (var i = 0; i < s.Length; i++)
            {
                if (i < s.Length -1)
                {
                    _newWord += s[i + 1];
                }
                else
                {
                    _newWord += s[0];
                }
            }
        
            _newWord += ' ';
        }

        return _newWord;
    }
}