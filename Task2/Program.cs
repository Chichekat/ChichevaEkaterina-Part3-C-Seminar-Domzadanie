// Программа, которая на вход принимает два числа и выдает 
// какое число больше и какое число меньше

Console.WriteLine("Введите число а: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a>b){
    Console.WriteLine($"Число а = {a} максимальное, а число b = {b} минимальное");
}
else {
    Console.WriteLine($"Число а = {a} минимальное, а число b = {b} максимальное");
}
