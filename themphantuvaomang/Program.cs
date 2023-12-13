class Program
{
    static void Main()
    {
        
        Console.Write("Nhập số phần tử của mảng (N): ");
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];
        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Phần tử thứ {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

       
        Console.Write("Nhập số cần chèn (X): ");
        int X = int.Parse(Console.ReadLine());

        
        Console.Write("Nhập vị trí index cần chèn X (tính từ 0): ");
        int index = int.Parse(Console.ReadLine());

        
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Không chèn được phần tử vào mảng. Vị trí index không hợp lệ.");
        }
        else
        {
            
            Array.Resize(ref array, array.Length + 1);
            for (int i = array.Length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = X;

            
            Console.Write("Mảng sau khi chèn phần tử X là: ");
            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }
        }
    }
}