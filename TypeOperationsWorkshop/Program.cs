namespace TypeOperationsWorkshop;

class Program
{
    static void Main(string[] args)
    {
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

    }
}
