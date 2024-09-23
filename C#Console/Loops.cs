

class Loops
{

    public static void ForLoops()
    {
        for(int i = 0; 1 <= 10; i++)
        {
            Console.WriteLine("Iteration: " + i);
        }
    }

    public static void EvenLoop()
    {
       for(int i = 1; i <= 20; i ++)
       {
           if(i % 2 == 1)
           {
            Console.WriteLine("Iteration: " + i);
           } 
       } 
    }

    public static void HealthLoop()
    {
        int health = 100;
        while(health >= 0)
        {
            Console.WriteLine("Player is alive with health: " + health);
            health -= 10;
        }
    }

     public static void NestedLoops()
    {
        for(int i = 0; i <= 2; i++)
        {
            Console.WriteLine("Iteration: i " + i);
             for(int j = 0; 1 <= 2; j++)
            {
                Console.WriteLine("     Iteration: j " + j);
                 for(int k = 0; i <= 2; j++);
            }
        }
    }

    public static void dowhile()
    {
        int number;

        do
        {
            Console.Write("Enter a number greater than 0; ");
            number = Convert.ToInt32(Console.ReadLine());
        }
        while (number <= 0);
        Console.WriteLine("You Entered: " + number);
    }
}