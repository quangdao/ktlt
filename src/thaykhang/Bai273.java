package thaykhang;

public class Bai273 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int[] arr = new int[]{ -35 ,-500,-256,-258 ,-800,-4,-15,-22,-39,-56};
		RemoveNegativeValues(arr);
		
	}
	
	public static void RemoveNegativeValues(int[] arr) 
	{
		int count = 0;
		int[] result = arr;
		for (int i = 0; i < arr.length; i++) {
			if (arr[i] < 0) {
				count++;
			}
		}
		if (count == 0) {
			System.out.print("No negative values");
			return;
			
		}
		
		for (int i = 0; i < count; i++) 
		{
			int index = FindIndexOfNegNumber(result);
			result = RemoveValue(result, index);			
		}
		
		for (int i = 0; i < result.length; i++) {
			System.out.print(result[i] + " ");
		}
	}
	
	public static int[] RemoveValue(int[] arr, int index)
	{
		int[] result = new int[arr.length - 1];
		for (int i = 0; i < index; i++) {
			result[i] = arr[i];
		}
		for (int i = index + 1; i <= result.length; i++) {
			result[i - 1] = arr[i]; 
		}
		return result;
	}
	
	public static int FindIndexOfNegNumber(int[] arr ) 
	{
		
		for (int i = 0; i < arr.length; i++) {
			if (arr[i] < 0) {
				return i;
			}
		}
		return -1;
	}

}
