// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
string number = Console.ReadLine();
int numberOfElements = number.Length;
   
int result = 0;
for (int i = 0; i < numberOfElements; i++){
    result += int.Parse(number[i].ToString());
}
//Console.WriteLine(numberOfElements);   
Console.WriteLine($"Сумма всех элементов числа {number} = {result}");

