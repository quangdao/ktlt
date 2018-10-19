package recursion;
import org.omg.CORBA.PUBLIC_MEMBER;

public class Bai739 {

	public static void main(String[] args) {
		System.out.print(Power(2,5));
	}
	
	public static float Power(int number, int pow) 
	{
		if (pow == 0)
			return 1;
		return(Power(number, pow - 1) * number);
	}

}
