using System;

class Program {
  public static void Main (string[] args) {
      Console.Write("Enter a number: ");
      while (true)
          {
              string input = Console.ReadLine();

              if (int.TryParse(input, out int number))
              {
                  if (number >= 1 && number <= 10000)
                  {
                      if (IsPerfect(number))
                      {
                          
                          Console.WriteLine("Perfect Number");
                      }
                      else
                      {
                          Console.WriteLine("Not a Perfect Number");
                      }
                  }
                  else
                  {
                      Console.WriteLine("Not a Perfect Number");
                  }
              }
              else
              {
                  Console.WriteLine("Invalid Input");
              }

              Console.WriteLine(); 
          }
      }
      static bool IsPerfect(int number)
      {
          int sum = 0;

          for (int i = 1; i <= number / 2; i++)
          {
              if (number % i == 0)
              {
                  sum += i;
              }
          }

          return sum == number;
      }
  }
