internal class Program
{
    private static void Main(string[] args)
    {
        int[] ints= {12,4,7,2,9};
        sort2(ints);

        foreach (var item in ints)
        {
            Console.WriteLine(item);
        }
    }

    public static void InsertionSort(int[] arry){
        int length = arry.Length;
        for (int i = 0; i < length; i++)
        {
            
            for (int j = i+1; j < length; j++)
            {
                if (arry[i] > arry[i+1]){
                int temp = arry[i+1];
                arry[i+1] = arry[i];
                arry[i] = temp;

            }
            }
        }





    }
    public static void sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++) {
            int key = arr[i];
            int j = i - 1;
 
            // Move elements of arr[0..i-1],
            // that are greater than key,
            // to one position ahead of
            // their current position
            while (j >= 0 && arr[j] > key) {
                arr[j+1] = arr[j];
                j = j - 1;
            }
            arr[j+1] = key;
        }
    }

    public static void sort2(int[] arr)
    {
        int n = arr.Length;
for (int i = 1; i < n; i++) {
    int key = arr[i];
    int j = i - 1;

    // Move elements of arr[0..i-1],
    // that are greater than key,
    // to one position ahead of
    // their current position
    for (; j >= 0; j--) {
        if (arr[j] > key) {
            arr[j+1] = arr[j];
        }
        else {
            break;
        }
    }
    arr[j + 1] = key;
}
    }
    public static void Sort3(int[] arr){
        int length = arr.Length;
        for (int i = 0; i < length; i++)
        {
            int key = arr[i];
            for (int j = i+1;  j  < length; j++)
            {
                if(arr[j] < key){
                    int temp = arr[j];
                    arr[j] = key;
                    arr[i] = temp;
                }
            }
        }
    }

}