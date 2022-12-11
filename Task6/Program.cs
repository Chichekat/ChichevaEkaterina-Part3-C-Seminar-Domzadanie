Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
if (N % 2 == 0){
    Console.WriteLine($"Число {N} четное");
}
else {
    Console.WriteLine($"Число {N} не четное");
}
