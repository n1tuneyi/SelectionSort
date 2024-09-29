namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [-101, -1, 4, 0, 312, 2, 111, 33 , -44, -99];

            SelectionSort(arr);

            Console.Write("Sorted array: ");

            foreach (var elem in arr)
            {
                Console.Write($"{elem} ");
            }

        }

        // Swap Helper Function
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void SelectionSort(int[] arr)
        {

            for (int currentPosition = 0; currentPosition < arr.Length - 1; currentPosition++)
            {
                // Assume that current element at this position is the smallest and start comparing 
                // this element with the following elements
                int minIndex = currentPosition;

                for (int j = currentPosition + 1; j < arr.Length; j++)
                {
                    // if we find a smaller element when for looping 
                    // then we assume that is the smallest number at that point
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }

                Swap(ref arr[currentPosition], ref arr[minIndex]);
            }
        }

    }
}
