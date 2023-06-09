void Task2(){
    
    Console.WriteLine("Введите  число");
    string input = Console.ReadLine();
    int num1 = Convert.ToInt32(input);
    int len = input.Length;
    bool is_poly = true;
    for (int first = 0; first < len; first++)
    {
        if (input[first] != input[len-first])
        {
            is_poly = false;
            break;
        }else{
            
        }  ;     
    }
    if (is_poly){
        Console.WriteLine ("Da");

    } else {
        Console.WriteLine("Net");
    }
}

Task2();
