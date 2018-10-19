package thaykhang;


public class Bai284 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] arr = new int[]{ 30,40,12,0,5,8,9,3};
		int[] result = ReverseEvenValues2(arr);
		int[] result2 = ReverseEvenValues(arr);
		for(int res:result) 
		{
			System.out.print(res + " ");
		}
		System.out.println("=========");
		for(int res2:result2) 
		{
			System.out.print(res2 + " ");
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

	public static int[] ReverseEvenValues2(int[] arr)
	{
		int[] result = new int[arr.length];
		int index = arr.length - 1;
		
		for (int i = 0; i < arr.length; i++) {
			if (arr[i] % 2 != 0) {
				result[i] = arr[i];
			}
			else {
				while (index >= 0 && arr[index] % 2 != 0) {
					index--;
				}
				result[i] = arr[index];
				index--;
			}
		}
		
		return result;
		
	}
}
