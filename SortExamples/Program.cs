using SortExamples;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> array = GetRandomArray(20);
        Console.WriteLine("Array before sorting");
        WriteArray(array);
        var bubble = new BubbleSort();
        List<int> sortedArray = bubble.SortInt(array);
        Console.WriteLine("Array after sorting");
        WriteArray(sortedArray);
    }

    /// <summary>
    /// Метод генерирует массив чисел в количестве Count и в указанном диапозоне
    /// </summary>
    /// <param name="count">Кол-во чисел в результате</param>
    /// <param name="diapasonStart">Начальный диапозон</param>
    /// <param name="diapasonEnd">Конечный диапозон</param>
    /// <returns>Массив случайныйх чисел</returns>
    private static List<int> GetRandomArray(int count, int diapasonStart = -300, int diapasonEnd = 300)
    {
        List<int> result = new List<int>();
        Random rnd = new Random();
        for (int i = 0; i < count; i++)
        {
            result.Add(rnd.Next(diapasonStart,diapasonEnd+1));
        }
        return result;
    }

    /// <summary>
    /// Вывести массив в консоль
    /// </summary>
    /// <param name="array">Массив данных</param>
    private static void WriteArray(List<int> array)
    {
        string arrayString = string.Join(",", array);
        Console.WriteLine($"Array: {arrayString}");
    }
}