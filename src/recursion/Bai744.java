package recursion;

import org.omg.CORBA.PUBLIC_MEMBER;

public class Bai744 {

	public static void main(String[] args) {
		System.out.print(Sum(3));

	}
	
	public static float Sum(float number)
	{
		if(number == 1)
			return 1;
		return (1/number + 1/(1 +(Sum(number - 1))));
	}

}
