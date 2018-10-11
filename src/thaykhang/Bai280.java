package thaykhang;

import java.util.Arrays;

public class Bai280 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] arr = new int[]{ 35 ,-500,1,258 ,800,1,15,22,39,9};
		
		int[] result = SortValueOne(arr);
		for (int i = 0; i < result.length; i++) {
			System.out.print(result[i] + " ");
		}
	}
	
	public static int[] SortValueOne(int[] arr) 
	{
		int[] result = new int[arr.length];
		Arrays.fill(result, 1);
		int index = arr.length -1;
		for (int i = arr.length -1; i >= 0; i--) {
			if (arr[i] != 1) {
				result[index--] = arr[i];

			}
		}
//		while (index >= 0) {
//			result[index--] = 1;
//		}
		
		
		return result;
		
	}

}
