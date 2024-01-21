using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        for (int i = 0; i < arr.GetUpperBound(0)-1; i++)
        {
            for (int j=i+1; j < arr.GetUpperBound(0); j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        
        for (int i = 0; i < arr.GetUpperBound(0); i++)
            Console.WriteLine(arr[i]);
    }
    
}