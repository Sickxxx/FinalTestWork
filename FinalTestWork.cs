void Solution1()
{
    Console.WriteLine("Введите колличество элементов в массиве:");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент в массиве:");
        array[i] = Console.ReadLine();
    }
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            string tmp = array[i];
            array[i] = array[count];
            array[count] = tmp;
            count++;
        }
    }
    if (count > 0)
    {
        Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символам:");
        for (int j = 0; j < count; j++)
        {
            Console.Write(array[j] + " ");
        }
    }
    else Console.WriteLine("В массиве нет элементов длина которых меньше либо равна 3 символам");

}
void Solution2()
{
    Console.WriteLine("Введите колличество элементов в массиве:");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент в массиве:");
        array[i] = Console.ReadLine();
    }
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    int j = 0;
    if (count > 0)
    {
        string[] new_array = new string[count];
        for (int i = 0; i < size; i++)
        {
            if (array[i].Length <= 3)
            {
                new_array[j] = array[i];
                j++;
            }
        }
        Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символам:");
        for (int k = 0; k < count; k++)
        {
            Console.Write(new_array[k] + " ");
        }
    }
    else Console.WriteLine("В массиве нет элементов длина которых меньше либо равна 3 символам");
}
Solution1();
Solution2();



