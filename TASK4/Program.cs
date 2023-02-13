// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


int a, b, c;

a = 15;
b = 20;
c = 35;
        
int max;
        
max = a;
if (b > max)
{
  max = b;
    if (c > max)
      {
       max = c;
       Console.WriteLine(max);
      }
      else
      {
        max = b;
        Console.WriteLine(max);
      }
        }
        else
        {
          max = a;
          Console.WriteLine(max);
        }
