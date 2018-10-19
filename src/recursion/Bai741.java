package recursion;

public class Bai741 {

	public static void main(String[] args) {
		System.out.print(Sum(2,3));
	}
	
	public static double Sum(int x, int number)
	{
		
		if(number == 0) 
			return 0;	
		return (Sum(x, number - 1) + Math.pow(x, number));
		
	}

}
