// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!!!");

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("What is your name?");
      // var name = Console.ReadLine();
      // var currentDate = DateTime.Now;
      // Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
      // Console.Write($"{Environment.NewLine}Press any key to exit...");
      // Console.ReadKey(true);


      // Console.WriteLine("Give me a name");
      // string name = Console.ReadLine();

      // Console.WriteLine("Give me an age");
      // var age = Console.ReadLine();
      // string ageWord = "young";

      // if (int.Parse(age) > 29)
      // {
      //   ageWord = "old";
      // }

      // Console.WriteLine($"There once was a person named {name}");
      // Console.WriteLine($"He was really {ageWord}");
      // Console.WriteLine($"He really likes the name {name}");
      // Console.WriteLine($"But didn't like being {age}");

      // string statement = "You win some. You lose some.";
      // Console.WriteLine(statement[0..(statement.Length / 2)] + " <- This is half");
      // var subs = statement.Split(" ");
      // Console.WriteLine(string.Join("\n", subs));

      // Console.WriteLine("Add two numbers");
      // Console.Write("First Number: ");
      // int num1 = int.Parse(Console.ReadLine());

      // Console.Write("Second Number: ");
      // int num2 = int.Parse(Console.ReadLine());

      // Console.WriteLine($"Your result: {num1 + num2}");

      // object[] misc = { "test", 2, 3, 4, 5 };

      // Console.WriteLine(misc[0]);
      // Console.WriteLine(misc[1]);

      // Console.WriteLine("WHAT'S YOUR NAME PAL?");
      // string response = SayHi(Console.ReadLine());
      // Console.WriteLine($"The Response: {response}");

      // Console.WriteLine(Cube(2));
      // Console.WriteLine($"The max between 4 and 8 is: {GetMax(4, 8)}");

      // string secretWord = "test";
      // int guessCount = 0;
      // int guessLimit = 3;
      // Console.WriteLine($"Guess the secret word! Guess Limit: {guessLimit}, Current: {guessCount}");
      // string guess = Console.ReadLine().ToLower();
      // guessCount++;

      // if (secretWord == guess)
      // {
      //   Console.WriteLine($"You guessed it right! The Secret word is {secretWord}");
      // }
      // else
      // {
      //   do
      //   {
      //     Console.WriteLine($"WRONG!!! Guess the secret word! Guess Limit: {guessLimit}, Current: {guessCount}");
      //     guess = Console.ReadLine().ToLower();
      //     guessCount++;
      //   } while (secretWord != guess && guessCount < guessLimit);

      //   if (secretWord == guess && guessCount <= guessLimit)
      //   {
      //     Console.WriteLine($"You guessed it right! The Secret word is {secretWord}");
      //   }
      //   else if (guessCount >= guessLimit)
      //   {
      //     Console.WriteLine($"Game over! You ran out of tries Limit: {guessLimit}, Guess count: {guessCount}");
      //   }
      // }

      // int[] luckyNumbers = { 1, 3, 45, 6, 7, 123, 666 };
      // for (int i = 0; i < luckyNumbers.Length; i++)
      // {
      //   Console.WriteLine(luckyNumbers[i]);
      // }

      // Book book1 = new Book("Harry Potter", "JK Rowling", 400);

      // Console.WriteLine($"{book1.title} by {book1.author} is {book1.pages} pages long");

      // Student student1 = new Student("Jim", "Buisness", 2.8);
      // Student student2 = new Student("Pam", "Art", 3.6);

      // Console.WriteLine(student1.HasHonors());
      // Console.WriteLine(student2.HasHonors());

      // Moive moive1 = new Moive("Jaws", "Steven Spielberg", "R");

      // moive1.Rating = "PG-13";
      // Console.WriteLine(moive1.Rating);

      // moive1.Director = "Bob";
      // Console.WriteLine(moive1.Director);

      // Song holiday = new Song("Holiday", "Green Day", 200);

      // Console.WriteLine(holiday.title);
      // Console.WriteLine(Song.songCount);
      // Console.WriteLine(holiday.getSongCount());

      // UsefulTools.SayHi("Juan");

      Chef bobTheChef = new Chef();
      bobTheChef.MakeChicken();
      ItalianChef mario = new ItalianChef();
      mario.MakeChicken();
      mario.MakeSpaghetti();
      mario.MakeSpecialDish();
    }

    static string SayHi(string name)
    {
      Console.WriteLine($"HELLO {name}");
      return $"Let me give you back your name: {name}";
    }

    static int Cube(int num)
    {
      return num * num * num;
    }

    static int GetMax(int num1, int num2)
    {
      return num1 > num2 ? num1 : num2;
    }
  }
}
