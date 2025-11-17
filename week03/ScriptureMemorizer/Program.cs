/* 
I added a feature where a user can put the scripture verses that they desire to memorize inside of a .txt file. I picked the .txt file because it
is a very user-friendly file that doesn't require for the user to enter the .cs file to put inside of a list. The user can enter as much as they like
with the same format as the one in the scipture.txt file. Whenever the user turns on the program, a different verse appears from the previous verse
so that the user can have a variety of scripture verses that they picked for themselves to memorize.

I also added something but it's not counted as a feature but an improvement. Previously, the program could only split one word on the scripture verse,
e.g. John, Proverbs, Moroni, etc. and could not include the number index of certain books like 1 Kings, 2 Samuel, 4 Nephi, etc. because it has 2 words
and could not split properly. That's why I added an upgraded version so that even those that has number index in the books can also be included in
the .txt file for the user to memorize with their own chosen scripture verses.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        string filePath = "scriptures.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: scriptures.txt not found.");
            return;
        }

        List<string> verses = new List<string>(File.ReadAllLines(filePath));

        if (verses.Count == 0)
        {
            Console.WriteLine("No verses found in scriptures.txt.");
            return;
        }

        Random random = new Random();

        int index = random.Next(verses.Count);
        string scriptureCitation = verses[index];

        string[] parts = scriptureCitation.Split(new string[] {" - "}, 3, StringSplitOptions.None);
        
        string referenceText = parts[0].Trim();
        string scriptureText = parts[1].Trim();

        string finalBookName;
        string verseUnsplit;
        string[] scriptureParts = referenceText.Split(new string[] {" "}, StringSplitOptions.None);

        if (scriptureParts.Length == 3)
        {
            string bookNumber = scriptureParts[0].Trim();
            string book = scriptureParts[1].Trim();
            verseUnsplit = scriptureParts[2].Trim();

            finalBookName = bookNumber + " " + book;
        }
        else
        {
            finalBookName = scriptureParts[0].Trim();
            verseUnsplit = scriptureParts[1].Trim();
        }

        

        string[] citationParts = verseUnsplit.Split(new string[]{":"}, StringSplitOptions.None);

        string chapterString = citationParts[0].Trim();
        string verseString = citationParts[1].Trim();

        int chapter = int.Parse(chapterString);
        int startVerse = 0;
        int endVerse = 0;
        Reference reference;

        for (int i = 0; i < verseString.Length; i++)
        {
            char numberInVerse = verseString[i];
            if (numberInVerse.ToString() == "-")
            {
                string[] verseParts = verseString.Split(new string[]{"-"}, StringSplitOptions.None);

                string startVerseString = verseParts[0];
                string endVerseString = verseParts[1];

                startVerse = int.Parse(startVerseString);
                endVerse = int.Parse(endVerseString);
            }
            else
            {
                startVerse = int.Parse(verseString);
            }
        }

        if (verseString.Contains("-"))
        {
            reference = new Reference(finalBookName, chapter, startVerse, endVerse);
        }
        else
        {
            reference = new Reference(finalBookName, chapter, startVerse);
        }

        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending...");
                break;
            }
        }

    }
}