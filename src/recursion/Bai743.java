package recursion;

public class Bai743 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.print(Sum(2,3));
	}
	
	public static double Sum(double x,double number) 
	{
		if (number == 0) {
			return Math.pow(x, 1);
		}
		return(Math.pow(x, 2 * number + 1) + Sum(x, number - 1));
	}

}
