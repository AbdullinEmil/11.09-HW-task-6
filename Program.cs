using System;

public class SentencesCapitalize
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        string capitalizedText = CapitalizeFirstLetterOfSentences(text);

        Console.WriteLine("\nРезультат:");
        Console.WriteLine(capitalizedText);
    }

    public static string CapitalizeFirstLetterOfSentences(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }

        string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

        string capitalizedText = "";
        foreach (string sentence in sentences)
        {
            capitalizedText += sentence.Trim().Substring(0, 1).ToUpper() + sentence.Trim().Substring(1) + " ";
        }

        return capitalizedText.Trim();
    }
}