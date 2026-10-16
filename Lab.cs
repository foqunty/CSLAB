/*
Console.Write("What is your name? :");
string name = Console.ReadLine()!;
Console.Write("Which city are you from? : ");
string city = Console.ReadLine()!;
Console.WriteLine($"Name: {name}");
Console.WriteLine($"City: {city}");
Console.WriteLine("Department: Computer Engineering");
Console.WriteLine("Year: 2");
Console.WriteLine("C# is fun");
Console.WriteLine($"Hello from {city} , welcome to c#\n");




Console.Write("First number: ");
double num1 = double.Parse(Console.ReadLine()!);
Console.Write("Second number: ");
double num2 = double.Parse(Console.ReadLine()!);
double sum = num1+num2 ;
double cikarma= num1-num2;
double carpma= num1 * num2;
double bolme = num1/num2;
Console.WriteLine($"{num1}+{num2} = {sum}");
Console.WriteLine($"{num1}-{num2} = {cikarma}");
Console.WriteLine($"{num1}*{num2} = {carpma}");
Console.WriteLine($"{num1}/{num2} = {bolme}\n");



Console.Write("Enter student name: ");
string name2 = Console.ReadLine()!;
Console.Write("Enter midterm score: ");
int score1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter final score: ");
int score2 = int.Parse(Console.ReadLine()!);
double avg = score1 * 0.4 + score2 * 0.6;
if(score2 == 100){
    Console.WriteLine("Perfect Final");
}
if(avg>50){
    Console.WriteLine($"{name2} your average is {avg:F2}");
    Console.WriteLine("PASSED");
}
else{
    Console.WriteLine($"{name2} your average is {avg:F2}");
    Console.WriteLine("FAILED");
}
Console.WriteLine("\n");


Console.Write("Enter a 3-digit number: ");
int number2 = int.Parse(Console.ReadLine()!);
int dig1 = number2/100;
int dig2 = (number2/10)%10;
int dig3 = number2%10;
Console.WriteLine($"Hunderds: {dig1}");
Console.WriteLine($"Tens: {dig2}");
Console.WriteLine($"Ones: {dig3}");
int sum2 = dig1+dig2+dig3;
Console.WriteLine($"Sum of digits: {sum2}");
if(number2%2==0){
    Console.WriteLine($"{number2} is even");
}
else{
    Console.WriteLine($"{number2} is odd");
}
if(dig1 == dig3){
    Console.WriteLine("First and last digits are same");
}
else{
    Console.WriteLine("First and last digits are different");
} 
*/
int score = 0;
while (true)
{
   Console.Write("Score: ");
   score = int.Parse(Console.ReadLine()!);
   Console.Write($"Score: {score} ");
    if (score == 0)
    {
        break;
    }
   if(score<0 || score > 100)
    {
        Console.Write("Invalid Score\n");
    }
    else if (score>=90)
    {
        Console.WriteLine("A");
    }
    else if (score>=80)
    {
        Console.WriteLine("B");
    }
    else if (score>=70)
    {
        Console.WriteLine("C");
    }
    else if (score >= 60)
    {
        Console.WriteLine("D");
    }
    else
    {
        Console.WriteLine("F");
    }
    
}
Console.WriteLine("\n");
int num = 1;
int sum = 0;
int count = -1;

while (num != 0)
{
    Console.Write("Number (0 to stop) : ");
    num = int.Parse(Console.ReadLine()!);
    sum += num;
    count++;
}

double avg = sum  / count;
Console.WriteLine($"Count : {count}, Sum : {sum}, Average : {avg:f2}");
 



