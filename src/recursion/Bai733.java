package recursion;

public class Bai733 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.print(Sum2n(5));
	}
	
	public static float Sum2n(int number)
	{
		if (number == 0) {
			return 1;
		}
		return(Sum2n(number-1) + 1/(2 * number));
	}
}
