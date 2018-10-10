package thaykhang;

public class Bai279 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] arr = new int[]{ 35 ,-500,-256,258 ,800,-4,15,800,22,39,56,35};
		int[] result = RemoveDuplicatedValues(arr);
		for (int i = 0; i < result.length; i++) {
			System.out.print(result[i] + " ");
		}
		
	}
	
	public static int[] RemoveDuplicatedValues(int[] arr) 
	{
		int[] countArray = new int[arr.length];
		int countDistinctValue = 0;
		for (int i = 0; i < arr.length; i++) 
		{
			countArray[i] = CountValueInArray(arr, arr[i]);
			if (countArray[i] == 1) 
			{
				countDistinctValue++;
			}
		}
				
		int[] result  = new int[countDistinctValue];
		int index = 0;
		for (int i = 0; i < arr.length; i++) 
		{
			if (countArray[i] == 1) {
				result[index] = arr[i];
				index++;
			}
		}
		return result;
	}
	
	public static int CountValueInArray(int[] arr, int value) 
	{
		int count = 0;
		
		for (int i = 0; i < arr.length; i++) {
			if (arr[i] == value) {
				count++;
			}
		}
		return count;
	}
	

}
