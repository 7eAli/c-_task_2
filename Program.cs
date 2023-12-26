namespace Hw_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            Show2dimArray(array);
            Sort2dimArray(array);
            Console.WriteLine();
            Show2dimArray(array);

        }

        static void Show2dimArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Sort2dimArray(int[,] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                int max = array[0, 0];
                int maxRow = 0; int maxCol = 0;
                int temp;
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        if (array[j, k] < max)
                        {
                            temp = array[j, k];
                            array[j, k] = max;
                            array[maxRow, maxCol] = temp;
                            maxRow = j; maxCol = k;
                        }
                        else if (array[j, k] > maxRow)
                        {
                            max = array[j, k];
                            maxRow = j; maxCol = k;
                        }
                    }
                }
            }
        }
    }
}
