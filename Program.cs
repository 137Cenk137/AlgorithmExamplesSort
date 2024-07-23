internal class Program
{
    private static void Main(string[] args)
    {
        int[] ints={64,25,12,22,11};

        Sort(ints);
        for (int i = 0; i <= ints.Length-1; i++)
        {
            Console.WriteLine(ints[i]);
        }
        
    }

    public static void Sort(int[] arry){
        int length = arry.Length;
        for (int i = 0; i <= length-1; i++)
        {
            int min_idx = i;
            for (int j = i+1 ; j < length; j++){
                if (arry[j] < arry[min_idx])
                    min_idx = j;
                    
            }


            int temp = arry[min_idx];
            arry[min_idx] = arry[i];
            arry[i] = temp;
        }

    }
    public static void Sort2(int[] arry){
        int length  =arry.Length;

        for (int i = 0; i <= length-1; i++)
        {
            int min_index = i;
            for (int j = i+1; j < length; j++)
            {
                if (arry[j] < arry[min_index]){
                    min_index = j;
                }
            }

            int temp = arry[min_index];
            arry[min_index] = arry[i];
            arry[i] = temp;

        }


    }

    public static void Sort4(int[] arry)
    {
        int length = arry.Length;
         for (int i = 0; i <= length-1; i++)
         {
                int min_index = i;
                for (int j = i+1; j < length; j++)//int j = 1 ; j < length; j++ olma durumu hakkında kafa yor
                {
                        if(arry[j]< arry[i])
                        {min_index = j;}
                }
                int temp  = arry[min_index];
                arry[min_index] = arry[i];
                arry[i] = temp;
         }

    }
}