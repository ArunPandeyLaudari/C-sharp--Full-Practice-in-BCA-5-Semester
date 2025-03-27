using  System;

 class Program {

    public static void Main() {

        int[] arr = new int[10];
        int i, j, temp;

        Console.WriteLine("Enter 10 elements:");

    for (i = 0; i < 10; i++) {
        arr[i] = int.Parse(Console.ReadLine());
    }


    for (i = 0; i < 10; i++) {
        for (j = i + 1; j < 10; j++) {
            if (arr[i] > arr[j]) {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
        Console.WriteLine("Ascending order:");
        for (i = 0; i < 10; i++) {
            Console.WriteLine(arr[i]);
        }
    }

}