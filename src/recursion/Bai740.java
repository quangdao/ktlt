package recursion;

public class Bai740 {
	public static void main(String[] args) {
		System.out.print(Sum(5));
		//System.out.print(Test(4));
	}
		
	public static int Sum(int number)
	{
		int result = 1;
		if (number == 1) {
			return 1;
		}
		for (int i = 1; i <= number; i++) {
			 result = result * i;
		}
		return result + Sum(number - 1);
	}
	
	
	
}
