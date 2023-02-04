// See https://aka.ms/new-console-template for more information

// System.Console.WriteLine("Первое задание");
// System.Console.WriteLine("Введите первое число");
// string St1 = Console.ReadLine();
// int value_1 = Convert.ToInt32(St1);
// System.Console.WriteLine("Введите второе число");
// string St2 = Console.ReadLine();
// int value_2 = Convert.ToInt32(St2);

// if (value_2>value_1)
// {
//     System.Console.WriteLine("max = " + value_2);
// }
// else
// {
//     System.Console.WriteLine("max = " + value_1);
// }

// System.Console.WriteLine("Второе задание");
// System.Console.WriteLine("Введите первое число");
// string Str1 = Console.ReadLine();
// int v_1 = Convert.ToInt32(Str1);
// System.Console.WriteLine("Введите второе число");
// string Str2 = Console.ReadLine();
// int v_2 = Convert.ToInt32(Str2);
// System.Console.WriteLine("Введите третье число");
// string Str3 = Console.ReadLine();
// int v_3 = Convert.ToInt32(Str3);

// if (v_2>v_1 && v_2>v_3 )
// {
//     System.Console.WriteLine("max = " + v_2);
// }

// if (v_1>v_2 && v_1>v_3 )
// {
//     System.Console.WriteLine("max = " + v_1);
// }

// if (v_3>v_1 && v_3>v_2 )
// {
//     System.Console.WriteLine("max = " + v_3);
// }

// System.Console.WriteLine("Третье задание");
// System.Console.WriteLine("Введите число");
// string num = Console.ReadLine();
// int number = Convert.ToInt32(num);
// if (number%2==0)
// {
//     System.Console.WriteLine("Число чётное");
// }
// else
// {
//     System.Console.WriteLine("Число нечётное");
// }

System.Console.WriteLine("Четвёртое задание");
System.Console.WriteLine("Введите число N");
string Num = Console.ReadLine();
int Number = Convert.ToInt32(Num);
int i=1;
while (i<=Number)
{
    if (i%2==0)
    {
        System.Console.WriteLine(i);
    }
    i=i+1;
}