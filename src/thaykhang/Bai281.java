package thaykhang;

public class Bai281 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] arr = new int[]{ 35 ,-500,-256,258, 0 ,800,-4,15,22,39,56, 0};
		int[] result = EvenFirstOddLast(arr);
		for(int res:result) 
		{
			System.out.print(res + " ");
		}
	}
	
	public static int[] EvenFirstOddLast(int[] arr) 
	{
		int[] result = new int[arr.length];
		int indexLast = result.length - 1 ;
		int indexFirst = 0;
		for (int i = 0; i < arr.length; i++) {
			if (arr[i] % 2 == 0 && arr[i] != 0) {
				result[indexFirst] = arr[i];
				indexFirst++;
			}
		}
		for (int i = arr.length - 1 ; i >= 0; i--) {
			if (arr[i] % 2 != 0) {
				result[indexLast--] = arr[i];
			}
		}
		return result;
	}

}
