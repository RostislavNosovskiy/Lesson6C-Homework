namespace Lesson6.L;
using System.Collections;
class Program
{
    public static void Main()
    {
        int[] arr = new int[] { 2, 3, 6, 17, 5, 6, 17, 13, 20, 8, 9, 1 };
        int sum = 20;
        var set = new HashSet<int>(arr);
       
        foreach (int i in set)
        {
            
            foreach (int j in set)
            {
                
                int x = sum - i - j;
                if (set.Contains(x) && x != i && i != j && x != j)
                {
                    Console.WriteLine($"{x} + {i} + {j} = {sum}");
                    set.Remove(x);  // удаление одного из чисел найденной суммы гарантирует, что данная комбинация чисел больше не выведется ни в одной другой последовательности
                }
                
            }
            
        }
       
    }
}