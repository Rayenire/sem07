//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[ ] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());       
}


int count = 0; 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
    Console.Write(array[i] + " ");
}

Console.WriteLine(); 
Console.WriteLine($"Кол-во элементов > 0: {count}");

