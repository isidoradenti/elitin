// Check if wordLength is within the bounds of the word
if (wordLength >= 0 && wordLength <= word.Length)
{
    // Assign the substring of word from start to wordLength
    word = word.Substring(0, wordLength);
}
else
{
    // Handle the case where wordLength is out of bounds
    // This could be logging an error, throwing an exception, or any other error handling mechanism
    Console.WriteLine("The word length provided is out of bounds.");
}
