internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] ints= { 5,3,4,1,2};
        BubbleSort.Sort(ints);
        BubbleSort.bubbleSort(ints,ints.Length);
    }
}


class BubbleSort{
    public static void Sort(int[] nums){
        var length = nums.Length;
        for (int i = 1; i < length; i++)
        {
            for (int k = 0; k < length-i; k++)
            {
                if (nums[k] > nums[k+1]){
                    int temp = nums[k];
                    nums[k] = nums[k+1];
                    nums[k+1] = temp;
                }
            }

        }

        for (int j = 0; j < length; j++)
        {
            Console.WriteLine(nums[j]);
        }
    }
    public static void bubbleSort(int[] arr, int n)
    {
        int i, j, temp;
        bool swapped;
        for (i = 0; i < n - 1; i++) {
            swapped = false;
            for (j = 0; j < n - i - 1; j++) {
                if (arr[j] > arr[j + 1]) {
                     
                    // Swap arr[j] and arr[j+1]
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
 
            // If no two elements were
            // swapped by inner loop, then break
            if (swapped == false)
                break;
        }


        for (int l = 0; l < n; l++)
        {
            Console.WriteLine(arr[l]);
        }
    }
 
}