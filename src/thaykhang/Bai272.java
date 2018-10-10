package thaykhang;

public class Bai272 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] arr = new int[] { 35, 500, 256, 258, 4, 15, 22, 39, 56 };
		RemoveGreatestNumber(arr);
		
        
	}
	
	
	public static void RemoveGreatestNumber(int[] arr) 
	{
		int indexOfGreatest = FindIndexOfGreatestValue(arr);
		int[] result = RemoveValue(arr, indexOfGreatest);
		for (int i = 0; i < result.length; i++) {
			System.out.print(result[i] + " ");
		}
		
	}
	
	public static int[] RemoveValue(int[]arr, int index)
	{
		int[] result = new int[arr.length -1];
		
		for (int i = 0; i < index; i++) {
			result[i] = arr[i];
		}
		for (int i = index + 1; i < arr.length; i++) {
			result[i - 1] = arr[i];
		}
		return result;
	}
	
	public static int FindIndexOfGreatestValue(int[] arr)
	{
		int greatest = arr[0];
		int index = 0;
		for (int i = 0; i < arr.length; i++) {
			if(arr[i] > greatest) 
			{
				greatest = arr[i];
				index = i;
			}
		}
		return index;
		
	}

}
