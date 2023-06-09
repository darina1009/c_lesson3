using System.Formats.Asn1;

Console.WriteLine("введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 1;

if(num1 <= 0){
    Console.WriteLine("попробуй еще раз");
}
else {
    while(num2<=num1)
    {int res = num2*num2*num2;
    Console.WriteLine(res);
    num2++;
    };
    
}