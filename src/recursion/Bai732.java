package recursion;

public class Bai732 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Sum(5);
		//System.out.print(Sum(5));
	}
	
	public static float Sum(float number)
	{
		if (number == 0) {
			return 0;
		}
		float sum = Sum(number - 1) + 1/number;
		System.out.println(sum);
		return sum;
	}

}
