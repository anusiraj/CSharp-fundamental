using System;

class Program
{
  static void Main(string[] args)
  {
    //Challenge 1
    int[][] arr1 = { new int[] { 1, 2 }, new int[] { 2, 1, 5 } };
    int[] arr1Common = CommonItems(arr1);
    /* write method to print arr1Common */

    //Challenge 2
    int[][] arr2 = { new int[] { 1, 2 }, new int[] { 1, 2, 3 } };
    InverseJagged(arr2);
    /* write method to print arr2 */

    //Challenge 3
    int[][] arr3 = { new int[] { 1, 2 }, new int[] { 1, 2, 3 } };
    CalculateDiff(arr3);
    /* write method to print arr3 */

    //Challenge 4
    int[,] arr4 = { { 1, 2, 3 }, { 4, 5, 6 } };
    // int[,] arr4Inverse = InverseRec(arr4);
    /* write method to print arr4Inverse */

    //Challenge 5
    Demo("hello", 1, 2, "world");

    //Challenge 6
    SwapTwo("hellon", "whatsup");
    SwapTwo(20, 30);
    //Challenge 7
    string firstName, middleName, lastName;
    ParseNames("Mary Elizabeth Smith", out firstName, out middleName, out lastName);
    Console.WriteLine($"First name: {firstName}, middle name: {middleName}, last name: {lastName}");

    //Challenge 8
    GuessingGame();
  }

  /*
  Challenge 1. Given a jagged array of integers (two dimensions).
  Find the common elements in the nested arrays.
  Example: int[][] arr = { new int[] {1, 2}, new int[] {2, 1, 5}}
  Expected result: int[] {1,2} since 1 and 2 are both available in sub arrays.
  // */
  static int[] CommonItems(int[][] jaggedArray)
  {
    Console.WriteLine("Challenge 1");
    int[] result = new int[2];
    for (int i = 0; i < jaggedArray.Length; i++)
    {
      int firstElement = jaggedArray[0][i];
      int secondElement = jaggedArray[0][i + 1];
      for (int j = 0; j <= jaggedArray[i].Length; j++)
      {
        if (firstElement == jaggedArray[i + 1][j] || secondElement == jaggedArray[i + 1][j])
        {
          result[i] = firstElement;
          result[i + 1] = secondElement;
          Console.WriteLine(string.Join(" ", result));
        }
      }
      break;
    }
    return result;

  }


  /* 
  Challenge 2. Inverse the elements of a jagged array.
  For example, int[][] arr = {new int[] {1,2}, new int[]{1,2,3}} 
  Expected result: int[][] arr = {new int[]{2, 1}, new int[]{3, 2, 1}}
   */
  static void InverseJagged(int[][] jaggedArray)
  {
    Console.WriteLine("Challenge 2");
    // int a = 0;
    // for (int i = 0; i < jaggedArray.Length; i++)
    // {
    //   for (int j = 0; j < jaggedArray[i].Length; j++)
    //   {
    //     for (int k = 1; k < jaggedArray[j].Length; k++)
    //     {
    //       a = jaggedArray[j][i];
    //       jaggedArray[j][i] = jaggedArray[j][k];
    //       jaggedArray[j][k] = a;
    //     }
    //     Console.WriteLine(string.Join(" ", jaggedArray[i]));
    //   }
    // }

  }

  /* 
  Challenge 3.Find the difference between 2 consecutive elements of an array.
  For example, int[][] arr = {new int[] {1,2}, new int[]{1,2,3}} 
  Expected result: int[][] arr = {new int[] {-1}, new int[]{-1, -1}}
   */
  static void CalculateDiff(int[][] jaggedArray)
  {
    Console.WriteLine("Challenge 4");
    // 
  }

  /* 
  Challenge 4. Inverse column/row of a rectangular array.
  For example, given: int[,] arr = {{1,2,3}, {4,5,6}}
  Expected result: {{1,2},{3,4},{5,6}}
   */
  // static int[,] InverseRec(int[,] recArray)
  // {

  // }

  /* 
  Challenge 5. Write a function that accepts a variable number of params of any of these types: 
  string, number. 
  - For strings, join them in a sentence. 
  - For numbers then sum them up. 
  - Finally print everything out. 
  Example: Demo("hello", 1, 2, "world") 
  Expected result: hello world; 3 */
  static void Demo(params object[] obj)
  {
    Console.WriteLine("Challenge 5");
    var builder = new System.Text.StringBuilder();
    int sum = 0;
    for (int i = 0; i < obj.Length; i++)
    {
      switch (obj[i])
      {
        case string str:
          builder.Append($"{str} ");
          break;
        case int num:
          sum = sum + num;
          break;
        default:
          break;
      }
    }
    Console.WriteLine($"{builder.ToString()};{sum}");

  }

  /* Challenge 6. Write a function to swap 2 objects but only if they are of the same type 
  and if they’re string, lengths have to be more than 5. 
  If they’re numbers, they have to be more than 18. */
  static void SwapTwo(params object[] obj)
  {
    Console.WriteLine("Challenge 6");
    string a = "Anu";
    int number = 0;
    for (int i = 0; i < obj.Length; i++)
    {
      switch (obj[0])
      {
        case string str when str.Length > 5:
          a = (string)obj[0];
          obj[0] = obj[1];
          obj[1] = a;
          break;
        case int num when num > 18:
          number = (int)obj[0];
          obj[0] = obj[1];
          obj[1] = number;
          break;
        default:
          break;
      }
      Console.WriteLine(string.Join(" ", obj));
    }
  }

  /* Challenge 7. Write a function to parse the first name, middle name, last name given a string. 
  The names will be returned by using out modifier */
  static void ParseNames(
      string input,
      out string firstName,
      out string middleName,
      out string lastName)
  {
    Console.WriteLine("Challenge 7");
    List<string> names = input.Split(' ').ToList();
    firstName = names[0];
    middleName = names[1];
    lastName = names[2];
  }

  /* Challenge 8. Write a function that does the guessing game. 
  The function will think of a random integer number (lets say within 100) 
  and ask the user to input a guess. 
  It’ll repeat the asking until the user puts the correct answer. */
  static void GuessingGame()
  {
    Console.WriteLine("Challenge 8");
    Console.WriteLine("Guess any number between 1 and 10!");
    System.Random random = new System.Random();
    int randomNum = random.Next(1, 10);
    Console.WriteLine($"Random number to test  = {randomNum}");
    int guessedNumber = Convert.ToInt32(Console.ReadLine());
    if (guessedNumber == randomNum)
    {
      Console.WriteLine("Number matches.You won");
    }
    else
    {
      Console.WriteLine("Number not matched.");
      GuessingGame();
    }
  }
}
