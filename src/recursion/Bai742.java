package recursion;

public class Bai742 {

	public static void main(String[] args) {
		System.out.print(Sum(2,3));
	}
	
	public static double Sum(double x,double number) 
	{
		if (number == 0) 
			return 0;
		return(Math.pow(x, number*2) + Sum(x, number - 1 ));
	}

}
