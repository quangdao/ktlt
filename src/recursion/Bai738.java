package recursion;

public class Bai738 {

	public static void main(String[] args) {
		System.out.print(Fact(3));

	}
	
	public static int Fact(int number) 
	{
		if (number == 0)
			return 1;
		return Fact(number -1 ) * number;
	}

}
