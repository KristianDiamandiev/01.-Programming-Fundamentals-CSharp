using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<StringBuilder> words = new List<StringBuilder>();
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        for (int i = 0; i < input.Length; i++)
        {
            words.Add(new StringBuilder(input[i]));
        }
        string[] input2 = Console.ReadLine().Split();
        string command;
        int ind1;
        int ind2;
        StringBuilder a = new StringBuilder();
        while (input2[0] != "3:1")
        {
            a = new StringBuilder("");
            command = input2[0];
            ind1 = int.Parse(input2[1]);
            ind2 = int.Parse(input2[2]);
            if (command == "merge")
            {
                if (ind1 < 0)
                    ind1 = 0;
                if (ind2 >= words.Count)
                    ind2 = words.Count - 1;
                if (ind1 >= words.Count )
                {
                    input2 = Console.ReadLine().Split();
                    continue;
                }
                for (int i = ind1+1; i <= ind2 && ind2 < words.Count; i++)
                {
                    words[ind1] = words[ind1].Append(words[i]);
                }
                words.RemoveRange(ind1+1, ind2-ind1);
            }
            if (command == "divide")
            {
                StringBuilder newElement = new StringBuilder("");
                int length = words[ind1].Length;
                StringBuilder word = words[ind1];
                StringBuilder piece = new StringBuilder("");
                int pieceLength = (length / ind2);
                if (length % ind2 == 0)
                {
                    List<StringBuilder> wordsAdditional2 = new List<StringBuilder>();
                    wordsAdditional2.Clear();
                    for (int i = 0; i < length; i+= pieceLength)
                    {
                        for (int j = i; j < i + (length / ind2); j++)
                        {
                            piece.Append(word[j]);
                        }
                        newElement.Append(piece + " ");
                        piece = new StringBuilder("");
                    }
                    string elements2 = newElement.ToString();
                    string[] splitedElements2 = elements2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < ind1; i++)
                    {
                        wordsAdditional2.Add(words[i]);
                    }
                    for (int i = 0; i < splitedElements2.Length; i++)
                    {
                        wordsAdditional2.Add(new StringBuilder(splitedElements2[i]));
                    }
                    for (int i = ind1 + 1; i < words.Count; i++)
                    {
                        wordsAdditional2.Add(words[i]);
                    }
                    words = wordsAdditional2;
                }
                else
                {
                    List<StringBuilder> wordsAdditional = new List<StringBuilder>();
                    wordsAdditional.Clear();
                    StringBuilder newElement2 = new StringBuilder("");
                    int k = 0;
                    for (int i = 0; i < ind2 - 1; i ++)
                    {
                        for (int j = 0; j < pieceLength; j++)
                        {
                            piece.Append(word[k]);
                            k++;
                        }
                        newElement2.Append(piece + " ");
                        piece = new StringBuilder("");
                    }
                    for (int l = k; l < length; l++)
                    {
                        newElement2.Append(word[l]);
                    }
                    string elements = newElement2.ToString();
                    string[] splitedElements = elements.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < ind1; i++)
                    {
                        wordsAdditional.Add(words[i]);
                    }
                    for (int i = 0; i < splitedElements.Length; i ++)
                    {
                        wordsAdditional.Add(new StringBuilder(splitedElements[i]));
                    }
                    for (int i = ind1 + 1; i < words.Count; i++)
                    {
                        wordsAdditional.Add(words[i]);
                    }
                    words = wordsAdditional;
                }
            }
            input2 = Console.ReadLine().Split();
        }
        Console.WriteLine(String.Join(" ", words));
    }
}

