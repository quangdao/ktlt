package recursion;

public class Bai734 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.print(Sum(3));
	}
	
	public static float Sum(float number)
	{
		if(number == 0) 
		{
			return 1;
		}
		
		return(Sum(number - 1) + 1 /(2 * number + 1));
	}

}
