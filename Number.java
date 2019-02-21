import java.util.Scanner;

class Number
{
	public static void main(String agr[])
	{
		Number numb= new Number();
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter your Number want to check : ");
		double n = sc.nextInt();
		numb.check(n);
	}

	public void check(double n)
	{
		if(n>0)
			System.out.println("Your input "+n+" is a positive number");
		else if(n<0)
			System.out.println("Your input "+n+" is a negative number");
		else
			System.out.println("Your input is Zero");
	}
}