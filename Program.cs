// Задание 1.1

// string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

// for (int i = days.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine($"{i}: {days[i]}");
// }

// Задание 1.2

// double[] temps = { 1.5, -2.3, 3.7, 4.1, 5.9, -1.0, -2.2};

// foreach (double temp in temps)
// {
//     Console.Write($"{temp} ");
// }

// Задание 2 и 3

// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// double srednee = 0;
// int count_more100 = 0;
// int minPrice = prices[0];
// foreach (int price in prices)
// {
//     sum += price;
//     if (price > 100)
//     {
//         count_more100++;
//     }
//     if (price < minPrice)
//     {
//         minPrice = price;
//     }
// }
// srednee = (double)sum / prices.Length;
// Console.WriteLine($"Сумма: {sum}");
// Console.WriteLine($"Среднее: {srednee}");
// Console.WriteLine($"Количество цен больше 100: {count_more100}");
// Console.WriteLine($"Минимальная цена: {minPrice}");
// int index_most_expensive = 0;
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] > prices[index_most_expensive])
//     {
//         index_most_expensive = i;
//     }
// }
// Console.WriteLine($"Индекс самой дорогой цены: {index_most_expensive}");

// Задание 4

// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
// }
// Console.WriteLine("Баланс после обнуления отрицательных значений:");
// foreach (int b in balance)
// {
//     Console.Write($"{b} ");
// }

// Самостоятельные задания

// // 4
// int[] nums = new int[5];
// int chetnie = 0;
// for (int i = 0; i < nums.Length; i++)
// {
//     Console.Write($"Введите число {i + 1}: ");
//     nums[i] = Convert.ToInt32(Console.ReadLine());
//     if (nums[i] % 2 == 0)
//     {
//         chetnie++;
//     }
// }
// for (int i = 4; i >= 0; i--)
// {
//     Console.WriteLine($"Число {i + 1}: {nums[i]}");
// }
// Console.WriteLine($"Количество четных чисел: {chetnie}");

// Задание 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// Console.WriteLine("-----------------------------------------------");
// for (int i = 0; i < names.Length; i++)
// {
//     Console.Write($"{i + 1}: {names[i]}, ");
// }
// Console.WriteLine();
// Console.WriteLine("-----------------------------------------------"); 
// string vivod = "Не найдено";
// Console.Write("Введите имя для поиска: ");
// string choosenName = Console.ReadLine();
// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == choosenName)
//     {
//         vivod = $"Имя {choosenName} найдено на позиции {i + 1}";
//         break;
//     }
// }
// Console.WriteLine(vivod);

// Итоговая задача

int[] grades = { 5, 4, 3, 5, 2, 4, 3, 5 };
double srednee = 0;
int sum = 0;
int min = grades[0];
int max = grades[0];
int count2 = 0;
int count5 = 0;
for (int i = 0; i < grades.Length; i++)
{
    sum += grades[i];
    if (grades[i] < min)
    {
        min = grades[i];
    }
    if (grades[i] > max)
    {
        max = grades[i];
    }
    if (grades[i] == 2)
    {
        count2++;
    }
    if (grades[i] == 5)
    {
        count5++;
    }
}
srednee = (double)sum / grades.Length;
Console.WriteLine($"Средний балл: {srednee}");
if (srednee >= 4.5)
{
    Console.WriteLine("Отличник");
} else if (srednee >= 3.5)
{
    Console.WriteLine("Хорошист");
} else
{
    Console.WriteLine("Есть над чем поработать");
}
Console.WriteLine($"Минимальный балл: {min}");
Console.WriteLine($"Максимальный балл: {max}");
Console.WriteLine($"Количество двоек: {count2}");
Console.WriteLine($"Количество пятерок: {count5}");

// Доп задание

// int[] arr = { 1, 2, 3, 4, 5, 6 };
// for (int i = 0; i < arr.Length / 2; i++)
// {
//     int num = arr[i];
//     arr[i] = arr[arr.Length - 1 - i];
//     arr[arr.Length - 1 - i] = num;
// }
// foreach (int b in arr)
// {
//     Console.Write($"{b} ");
// }
