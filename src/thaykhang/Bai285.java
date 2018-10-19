package thaykhang;

public class Bai285 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] arr = new int[]{ 35 ,-500,-256,258, 0 ,800,-4,15,22,39,56, 0};
		int[] result = ReversePosValues(arr);
		for(int res:result) 
		{
			System.out.print(res + " ");
		}
	}
	
	public static int[] ReversePosValues(int[] arr) 
	{
		int[] result = new int[arr.length];
		int index = arr.length - 1;
		for (int i = 0; i < arr.length; i++) {
			if (arr[i] < 0)
			{
				result[i] = arr[i];
			}
			else if(arr[i] == 0) 
			{
				result[i] = arr[i];
							}
			else {
				while (index >= 0 && arr[index] <= 0) {
					index--;
				}
				result[i] = arr[index];
				index--;
			}
		}
		return result;
		
	}

}
