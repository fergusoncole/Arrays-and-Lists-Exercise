

    //TODO:

    // Create an int Array and populate numbers 1-10
    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //int[] ints = new int[10];
    //for (int i = 0; i < ints.Length; i++)
   // {
    //    ints[0] = i + 1;
   // }


    /* Create two Lists of type int.
     * Name one List "evens"
     * Name the other List "odds"
     */
    var evens = new List<int>();
    var odds = new List<int>();

    /* Using either a foreach or for loop,
     * nest an if statement to check to see
     *  if a number is even or odd.
     * Then add those numbers to either the evens List
     * or the odds List
     */
    foreach (var number in arr)
    {
        if (number % 2 == 0)
        {
            evens.Add(number);
        }
        else
        {
            odds.Add(number);
        }
    }

    /* Now using foeach or for loops,
     * display each List of even and odd numbers
     *
     * Try to be creative in your display
     */
    Console.WriteLine($"This is the list of evens:");
    for (int i = 0; i < evens.Count; i++)
    {
        Console.Write($"{evens[i]}");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"This is the list of odds:");
    foreach (var number in odds)
    {
        Console.Write($"{number}");
    }
       
Console.WriteLine();
Console.WriteLine();
    
       