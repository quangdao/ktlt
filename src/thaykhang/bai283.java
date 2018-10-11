package thaykhang;

public class bai283 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] arr = new int[]{ 30,40,12,0,5,8,9,3};
		int[] result = ReverseArray(arr);
		for(int res:result) 
		{
			System.out.print(res + " ");
		}
	}
	
	public static int[] ReverseArray(int[]arr) 
	{
		int[] result = new int[arr.length];
		int index = 0;
		for (int i = arr.length - 1 ; i >= 0; i--) {
			result[index++] = arr[i];
		}
		return result;
		
	}

}
