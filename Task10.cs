// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите 3-х значное число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n >99 && n < 1000 ) {
    n = n / 10;
    n = n % 10;
    Console.WriteLine(n); 
}
else if (n < -99 && n > -1000) {
    n = n / 10;
    n = n % 10;
    Console.WriteLine(n); 
}
else {
    Console.WriteLine("Введенное число не является 3-х значным");
}