string[] PairwiseUnion(string[] words)
{

    string[] combined = new string[words.Length / 2];

    for (int j = 0, i = 0; i < words.Length; i += 2, j++)
        combined[j] = words[i] + words[i + 1];

    return combined;
}

void ShowString(string[] words)
{
    for (int i = 0; i < words.Length; i++)
        Console.Write($"{words[i]}  ");
    Console.WriteLine();
}

string[] verysad = { "I", "want", "more", "lessons", "with", "you"};

ShowString((PairwiseUnion(verysad)));