package recursion;

public class Bai731 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.print(SumSquare(5));
	}
	
	public static double SumSquare(int number) 
	{
		if (number == 0) {
			return 0;
		}
		return(SumSquare(number - 1) + Math.pow(number,2));	
	}
}
