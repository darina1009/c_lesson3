  Console.Write("Введите число: ");
string number = Console.ReadLine();

  
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"да {number} палиндром");
  }
  else Console.WriteLine($"нет {number} - не палиндром");


