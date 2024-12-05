using System.Diagnostics;

namespace Loops;

class Program
{
    static void Main(string[] args)
    {
		Colours trafficLigths = Colours.Green;
		if(int.Parse(args[0]) > 100000)
		{
			trafficLigths = Colours.Red;
		}
		if(trafficLigths == Colours.Red)
		{
			int trafficLigthsNum = (int)trafficLigths;
		}
		
		var dateTime = DateTime.Now.Year; //DateTime.Now.Month
		
		
		Stopwatch sw = new Stopwatch();
		sw.Start();
		PrintFibonacciSeriesByLoops(int.Parse(args[0]));
        //PrintFibonacciSeries(int.Parse(args[0]));
		sw.Stop();
		Console.WriteLine();
		Console.WriteLine($"{sw.ElapsedTicks}");
		Console.WriteLine($"{sw.ElapsedMilliseconds}");
    }

    static void PrintFibonacciSeries(int n, int current = 0, ulong a = 0, ulong b = 1)
    {
        if (current < n)
        {
            //Console.Write(a + " ");
            PrintFibonacciSeries(n, current + 1, b, a + b);
        }
    }
	
	static void PrintFibonacciSeriesByLoops(int n)
	{
		ulong prev = 0;
		ulong current = 1;
		
		//Console.Write("0 ");
	
		for(int i = 1; i < n; i++)
		{
			//Console.Write(current + " ");
			current = prev + current;
			prev = current - prev;
		}
	}
	
	static void PrintFibonacciSeriesByLoopsWhile(int n)
	{
		ulong prev = 0;
		ulong current = 1;
		
		//Console.Write("0 ");
		int i = 1;
		while( i < n )
		{
			//Console.Write(current + " ");
			current = prev + current;
			prev = current - prev;
			i++;
		}
	}
	bool CheckPalindrome(int n) 
	{
		if (n > 9999 || n < 1) 
		{
			throw new ArgumentException("число некорректно");
		}
		if (n < 110) 
		{
			return false;
		}
		if ((n < 1000) && (n % 10 == 0))
		{
			return (n / 100 == (n % 100 / 10));
		}
		return ((n % 1000 / 100) == (n % 100 / 10)) && (n / 1000 == n % 10);
		
	}
	string FindUniqueChars(string a, string b, string c)
	{
		string result = "";
		string str = $"{a}{b}{c}";
		foreach (char chr in str)
		{
			int countOfMatch = IsLetterInWord(chr, a) + 
				IsLetterInWord(chr, b) + 
				IsLetterInWord(chr, c);
				
			if (countOfMatch == 1)
			{
				result += chr;
			}
		}
		return result;
	}
	
	int IsLetterInWord(char letter, string word)
	{
		return word.Contains(letter) ? 1 : 0;
	}
	static string ReverseWords(string text)
	{
		string[] words = text.Split(); 
		
		if (words.Length < 2)
		{
			throw new ArgumentException("Недостаточно слов");
		}
		(words[0], words[^1]) = (words[^1], words[0]);
		
		return string.Join(" ", words);
	}
	
	static int UniqueMorseRepresentations(string[] words) 
	{
        
		string[] morseCode = new string[] 
		{
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---",
            "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-",
            "..-", "...-", ".--", "-..-", "-.--", "--.."
        };

        string[] uniqueTransformations = new string[words.Length];
        int uniqueCount = 0;

        foreach (string word in words) 
		{
            string transformation = "";

            foreach (char c in word) 
			{
                transformation += morseCode[c - 'a'];
            }

            // Проверка уникальности
            bool isUnique = true;
            for (int i = 0; i < uniqueCount; i++) 
			{
                if (uniqueTransformations[i] == transformation) 
				{
                    isUnique = false;
                    break;
                }
            }

            if (isUnique) 
			{
                uniqueTransformations[uniqueCount] = transformation;
                uniqueCount++;
            }
        }

        return uniqueCount;
    }
	static int NumUniqueEmails(string[] emails)
    {
        string[] uniqueEmails = new string[emails.Length];
        int uniqueCount = 0;

        foreach (string email in emails)
        {
	        if (email.StartsWith($"+"))
	        {
		        throw new Exception();
	        }
	        
            string[] parts = email.Split('@');
            string localName = parts[0];
            string domainName = parts[1];

            // Process local name
            char[] processedLocalName = new char[localName.Length];
            int index = 0;
            foreach (char c in localName)
            {
                if (c == '+')
                {
                    break;
                }
                if (c != '.')
                {
                    processedLocalName[index++] = c;
                }
            }

            string normalizedEmail = new string(processedLocalName, 0, index) + "@" + domainName;

            // Check if the normalized email is unique
            bool isUnique = true;
            for (int j = 0; j < uniqueCount; j++)
            {
                if (uniqueEmails[j] == normalizedEmail)
                {
                    isUnique = false;
                    break;
                }
            }

            if (isUnique)
            {
                uniqueEmails[uniqueCount] = normalizedEmail;
                uniqueCount++;
            }
        }

        return uniqueCount;
    }
	static bool WordPattern(string pattern, string s) {
        string[] words = s.Split(' ');
        
        if (pattern.Length != words.Length) {
            return false;
        }
        
        // Используем массивы кортежей для хранения соответствий
        var charToWord = new (char, string)[pattern.Length];
        var wordToChar = new (string, char)[pattern.Length];
        int count = 0;
        
        for (int i = 0; i < pattern.Length; i++) {
            char c = pattern[i];
            string word = words[i];
            
            bool charExists = false;
            bool wordExists = false;
            
            for (int j = 0; j < count; j++) {
                if (charToWord[j].Item1 == c) {
                    charExists = true;
                    if (charToWord[j].Item2 != word) {
                        return false;
                    }
                }
                
                if (wordToChar[j].Item1 == word) {
                    wordExists = true;
                    if (wordToChar[j].Item2 != c) {
                        return false;
                    }
                }
            }
            
            if (!charExists && !wordExists) {
                charToWord[count] = (c, word);
                wordToChar[count] = (word, c);
                count++;
            } else if (!charExists || !wordExists) {
                return false;
            }
        }
        
        return true;
    }
}

public enum Colours : int
{
	Red = 1,
	Yellow = 2,
	Green = 4
}


