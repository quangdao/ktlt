package thaykhang;

public class Bai282 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] arr = new int[]{ 30,40,12,0,5,8,9,3};
		int[] result = ChiaHetChoBa(arr);
		for(int res:result) 
		{
			System.out.print(res + " ");
		}
	}
	
	public static int[] ChiaHetChoBa(int[] arr)
	{
		int[] result = new int[arr.length];
		int index = 0;
		int indexLast = arr.length - 1;
		for (int i = 0; i < arr.length; i++) {
			if (arr[i] % 3 == 0 && arr[i] != 0) {
				result[index++] = arr[i];
			}
			else {
				result[indexLast--] = arr[i];
			}
		}
		return result;
	}

}
