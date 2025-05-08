int number;
Console.WriteLine("Lütfen Bir Sayı gir.");

number =(Convert.ToInt32(Console.ReadLine()));

if (number > 10)
{
    Console.WriteLine("Girilen Sayı 10'dan büyüktür.");

    if (number % 2 == 0)
    {
        Console.WriteLine("Girilen Sayı Çifttir.");
    }
else
    {
        Console.WriteLine("Girilen Sayı Tektır.");
    }
}
else if (number < 10)
{
    Console.WriteLine("Girilen Sayı 10'dan küçüktür.");
    if (number % 2 == 0)
    {
        Console.WriteLine("Girilen Sayı Çifttir.");
    }
    else
    {
        Console.WriteLine("Girilen Sayı Tektır.");
    }   
}
else
{
    Console.WriteLine("Girilen Sayı 10'a eşittir.");
    Console.WriteLine("Girilen Sayı çifttir.");
}

