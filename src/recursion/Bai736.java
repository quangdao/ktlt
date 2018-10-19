package recursion;

public class Bai736 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.print(Sum(3));
	}
	
	public static float Sum(float number)
	{
		if(number == 0)
			return 0;
		return (Sum(number - 1) + number/(number + 1));
	}

}
