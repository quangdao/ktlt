package thaykhang;

public class Bai278 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] arr = new int[]{ 35, 29,56,31,  23, 29, 40, 31, 50, 37,31, 41, 60, 29, 60};
		//RemoveDuplicates(arr);
		
		int[] newArr = KiRemoveDuplicatedValues(arr);
		
		for (int e : newArr)
		{
			System.out.print(e + " ");
		}
		
		
	}
	
	public static int[] RemoveDuplicatedValue(int[] arr)
	{
		int[] duplciatedCountArr = new int[arr.length];
		
		// Dem so luong trung
		for (int i = 0; i < arr.length; i++)
		{
			int tempCount = 0;
			for (int j = i - 1; j >= 0; j--)
			{
				if (arr[i] == arr[j])
					tempCount++;
			}
			duplciatedCountArr[i] = tempCount;
		}
		
		// Dem bao nhiu phan tu count co gia tri 0
		int newArrayCount = 0;
		for (int i = 0;i < duplciatedCountArr.length; i++)
		{
			if (duplciatedCountArr[i] == 0)
				newArrayCount++;
		}
		
		
		// Tao mang moi, bo vao neu count = 0
		int[] result = new int[newArrayCount];
		int index = 0;
		for (int i = 0; i < arr.length; i++)
		{
			if (duplciatedCountArr[i] == 0)
			{
				result[index] = arr[i];
				index++;
			}
		}
		
		return result;
		
	}
	
	public static int[] KiRemoveDuplicatedValues(int[] arr) 
	{
		boolean[] countDuplicate = new boolean[arr.length];
		
		for (int i = 0; i < arr.length; i++) 
		{
			boolean flag = true;
			for (int j = i - 1; j >= 0  ; j--) 
			{
				if (arr[i] == arr[j]) {
					flag = false;
				}
				
			}
			countDuplicate[i] = flag;
		}
		
		int count = 0;
		for (int i = 0; i < countDuplicate.length; i++) {
			if (countDuplicate[i] == true) {
				count++;
			}
		}
		int index = 0;
		int[] result = new int[count];
		for (int i = 0; i < arr.length; i++) {
			if (countDuplicate[i] == true) {
				result[index] = arr[i];
				index++;
			}
		}
		
		return result;
		
	}
	
	public static void RemoveDuplicates(int[] arr) 
	{
		int[] result = arr;
		
		for (int i = 0; i < arr.length; i++) 
		{		
			int count =  CountDuplicatedValue (result,arr[i]);
			if (count > 1)
			{
				for (int j = 0; j < count - 1; j++) 
				{
					result = RemoveValue(result,arr[i]);
				}
			}
		}
		
		for (int i = 0; i < result.length; i++) {
			System.out.print(result[i] + " ");
		}
	}
	
	public static int[] RemoveValue(int[] arr, int value) 
	{
		int[] result = new int[arr.length - 1];
		int index = 0;
		for (int i = 0; i < arr.length; i++) {
			if (arr[i] == value)
			{
				index = i;
				break;
			}
		}
		for (int i = 0; i < index; i++) 
		{
			result[i] = arr[i];
		}
		
 		for (int i= index; i < result.length; i++)
		{
			result[i] = arr[i+1];
		}
		
		return result;
	}
	
	public static int CountDuplicatedValue(int[] arr,int number)
	{
		int count = 0;
		for (int i = 0; i < arr.length; i++) 
		{
			if(arr[i] == number) 
			{
				count++;
			}
		}
		return count;
	}
}
	

