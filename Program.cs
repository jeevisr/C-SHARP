using Program;
class Program{
 static void main()
   {
     console.Write("enter a number:");
	 int number=convert.ToInt32(Console.ReadLine());
	 
	 if (IsAmstrongNumber(number))
	 {
	  console.WriteLine(number +"is an Amstrong number.");
	  }
	  else
	  {
	  console.WriteLine(number +"is not an Amstrong number.")'
	  }
	  }
	  static bool IsAmstrongNumber(int number)
	  {
	  int originalNumber=number;
	  int sum=0;
	  int numberOfDigits=number.ToString().Length;
	  
	  while(number>0)
	  {
	  int digit =number%10;
	  sum+=(int)Math.Pow(digit,numberOfDigits);
	  number/=10;
	  }
	  return originalNumber=sum;
	  }
	  }