package recursion;

public class Bai730 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.print(Sum(5));
	}
	
	public static int Sum(int number)
	{
		
		if (number == 0)
		{
			return 0;
		}
		
		return(Sum(number - 1) + number);
		
	}

}
