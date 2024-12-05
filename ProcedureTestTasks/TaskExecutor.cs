namespace ProcedureTestTasks;

public static class TaskExecutor
{
    public static int UniqueMorseRepresentations(string[] words) 
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
	
	
	public static int NumUniqueEmails(string[] emails)
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
	
	
	public static bool WordPattern(string pattern, string s) {
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