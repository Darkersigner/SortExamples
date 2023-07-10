namespace SortExamples;

public class BubbleSort
{
    /// <summary>
    /// Сортировка массива по возрастанию
    /// </summary>
    /// <param name="array">Массив данных</param>
    /// <returns>Результирующий массив</returns>
    public List<int> SortInt(List<int> array)
    {
        for (int i = 0; i < array.Count; i++)
        {
            for (int j = 0; j < array.Count-1; j++) //Здесь используется array.Count -1 чтобы не вылететь за границы массива
            {
                int current = array[j];
                var next = array[j + 1];
                if (current > next)
                {
                    int temp = current; 
                    array[j] = next; 
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }
}