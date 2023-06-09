void Task2(){
    
    Console.WriteLine("Введите  число");
    string input = Console.ReadLine();
    int num1 = Convert.ToInt32(input);

    for (int first = 0, last = input.Length - 1; first < last; ++first, --last)
    {
        if (input[first] = input[last])
        {
         Console.WriteLine("да");
        }else{
            Console.WriteLine("нет");
        }  ;     
    }
}

Task2();

//static bool IsPalindrom(string word, bool ignoreCase = true)
//{
   // if (ignoreCase)
   // {
  //      word = word.ToLowerInvariant();
//}

//for (int first = 0, last = word.Length - 1; first < last; ++first, --last)
  //  {
  //      if (word[first] != word[last])
  //      {
  //          return false;
  //      }
  //  }

   // return true;
//}