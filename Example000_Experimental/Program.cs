string charsWords = "аисвgh";
int countCharsInWords = 6;
PrintAllWords(charsWords,countCharsInWords,"");
void PrintAllWords(string alphabet,int length,string prefix){
  if(length==0) Console.WriteLine(prefix);
  else
   foreach(char c in alphabet) PrintAllWords(alphabet,length-1,prefix+c);
}
// for (; matrix[i, j] == 0 && j < matrix.GetLength(1) - 1; j++)
        // {
        //     matrix[i, j] = meaning;
        //     meaning++;
        // }
        // j--;
        // i++;
        // for (; matrix[i, j] == 0 && i < matrix.GetLength(0) - 1; i++)
        // {
        //     matrix[i, j] = meaning;
        //     meaning++;
        // }
        // i--;
        // for (; matrix[i, j] == 0 && j >= 0; j--)
        // {
        //     matrix[i, j] = meaning;
        //     meaning++;
        // }
        // j++;
        // for (; matrix[i, j] == 0 && i > 0; i--)
        // {
        //     matrix[i, j] = meaning;
        //     meaning++;
        // }
        for (; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = meaning;
            meaning++;
        }
        j--;
        i++;
        for (; i < matrix.GetLength(0); i++)
        {
            matrix[i, j] = meaning;
            meaning++;
        }
        i--;
        for (; j >= 0; j--)
        {
            matrix[i, j] = meaning;
            meaning++;
        }
        j++;
        for (; i > 0; i--)
        {
            matrix[i, j] = meaning;
            meaning++;
        }

        Console.WriteLine($"j={j}, i={i}");
        Console.WriteLine();