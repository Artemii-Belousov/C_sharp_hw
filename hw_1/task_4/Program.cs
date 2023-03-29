// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные чсла от 1 до N.



System.Console.WriteLine("Enter a number: ");
int n = int.Parse(System.Console.ReadLine());
//  При использовании цикла While необходимо объявить переменную преред циклом, а при использовании цикла for эта переменная объявляется внутри условия.

//  При помощи цикла while
// int i = 1;
// while(i <= n)
// {
//     if(i % 2 == 0)
//     {
//         Console.Write(i);
//         Console.Write(" ");
//     }
//     i++;
// }

// При помощи цикла for
for (int i = 1; i <= n; i++)
{    
    if(i % 2 == 0)
    {
        System.Console.WriteLine(i);
        System.Console.WriteLine(" ");
        
    }
}
