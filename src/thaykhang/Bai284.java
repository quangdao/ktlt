package thaykhang;


public class Bai284 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] arr = new int[]{ 4,7,2,5,3,9,10,8};
		int[] result = ReverseEvenValues(arr);
		for(int res:result) 
		{
			System.out.print(res + " ");
		}
	}
	
	public static int[] ReverseEvenValues(int[] arr) 
	{
		int[] result = new int[arr.length];
		int countEven = 0;
		for (int i = 0; i < result.length; i++) {
			if (arr[i] % 2 == 0)
			{
				result[i] = 1;
				countEven++;
			}
		}
		
		int[] reversedEvenNumber = new int[countEven];
		int index = 0;
		for (int i = arr.length - 1; i >= 0; i--) {
			if (arr[i] % 2 == 0)
			{
				reversedEvenNumber[index++] = arr[i];
			}
		}
		
		int indexEven = 0;
		for (int i = 0; i < result.length; i++) {
			if (result[i] == 1)
			{
				result[i] = reversedEvenNumber[indexEven++];
			}
		}
		
		for (int i = 0; i < result.length; i++) {
			if (arr[i] % 2 != 0)
			{
				result[i] = arr[i];
			}
			
		}
				
		return result;
	 
	}

}
