

    class If
    {

        public static void Numbers(int number)
        {
           
          if(number > 0)
          {
                Console.WriteLine("Your number is Positive. ");
          }  
          else if (number < 0) 
          {
                Console.WriteLine("Your number is Negative. ");
          }
          else 
          {
                Console.WriteLine("Your number is Zero. ");
          }
        }

        public static void health(int health)
        {
            if(health > 75)
            {
                Console.WriteLine("Your Health is in Great Condition. ");
            }
            else if (health > 50)
            {
                Console.WriteLine("Your health is in Good Condition");
            }
            else if (health > 0)
            {
                Console.WriteLine("You are close to death.");
            }
            else
            {
                Console.WriteLine("You are dead. ");
            }
        }
    }