namespace TypeOperationsWorkshop;

class Program
{
    static void Main(string[] args)
    {
		/*
		string name = Console.ReadLine();
		int age = int.Parse(Console.ReadLine());
		int course = 2024-2015;
		string groupNumber = Console.ReadLine();
		bool hasHomePet = age > 50;
		
		Console.WriteLine("Анкета студента:");
		Console.WriteLine($"Вас зовут {name}");
		Console.WriteLine("Вам " + age + " лет");
		Console.WriteLine("Вы на " + course + " курсе");
		Console.WriteLine("В группе " + groupNumber);
		Console.WriteLine("Есть ли у вас домашний питомец: " + hasHomePet);	
		*/
		try
		{
			Console.WriteLine(CalculateOp(10, 5, '-'));
			Console.WriteLine(CalculateOp(13, 0, '/'));
			Console.WriteLine(CalculateOp(10, 5, '+'));
			Console.WriteLine(CalculateOp(10, 5, '*'));
			Console.WriteLine(CalculateOp(10, 5, '^'));
			Console.WriteLine(CalculateOp(10, 5, '&'));
		}
		catch(DivideByZeroException dbzex)
		{
			Console.WriteLine($"Произошло деление на 0!");
		}
		catch(Exception ex)
		{
			Console.WriteLine($"Произошла ошибка: {ex.Message}");
		}	
		
    }
	
	static double CalculateOp(long a, long b, char operand)
	{
		return operand == '+'
			? a + b
			: operand == '-'
				? a - b
				: operand == '*'
					? a * b
					: operand == '/'
						? (double) a / b
						: operand == '^'
							? Math.Pow(a, b)
							: throw new NotSupportedException("operand not supported!");
		
		/*
		switch(operand)
		{
			case '+':
				return a + b;
			case '-':
				return a - b;
			case '*':
				return a * b;
			case '/':
				return (double)(a / b);
			case '^':
				return Math.Pow(a, b);
			default:
				throw new NotSupportedException("operand not supported!");
		}
		*/
	}
}
