int sum=0;int number,x=0,min;

Console.ForegroundColor=ConsoleColor.Blue;
System.Console.WriteLine("plases enter nomre");
number=Convert.ToInt32(Console.ReadLine());

while(number !=0)
{
 sum=sum+number;
 x++;
System.Console.WriteLine("plases enter nomre");
number=Convert.ToInt32(Console.ReadLine());
}
min=sum/x;
System.Console.WriteLine("javab"+min);
