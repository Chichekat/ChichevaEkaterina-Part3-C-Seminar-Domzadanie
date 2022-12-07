// Напишите программу, которая на вход принимает 3 числа
// и выдает максимальное из этих чисел

Console.WriteLine("Введите число а: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine());
int max = a;
if (a > max){
    max = a;
}
 if (b > max){
    max = b;
}
 if (c > max){
    max = c;
} 
 Console.WriteLine($"Максимальное число = {max}");
