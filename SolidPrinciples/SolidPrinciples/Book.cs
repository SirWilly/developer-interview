namespace SolidPrinciples;

public class Book {

    private String name;
    private String author;
    private String text;

    public String ReplaceWordInText(string word, string replacementWord){
        return text.Replace(word, replacementWord);
    }

    public bool IsWordInText(string word){
        return text.Contains(word);
    }

    public void PrintTextToConsole()
    {
        Console.Write(text);
    }
}