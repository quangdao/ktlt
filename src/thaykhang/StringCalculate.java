package thaykhang;

import java.util.stream.Stream;

import javax.swing.text.StyledEditorKit.ForegroundAction;

import org.omg.CORBA.PUBLIC_MEMBER;

import com.sun.javafx.scene.layout.region.Margins.Converter;
import com.sun.org.apache.xalan.internal.xsltc.compiler.Template;

import sun.net.TelnetOutputStream;

public class StringCalculate {

	
	
	

public static void main(String[] args) {
		
		System.out.print(PlusTwoStrings("999","6552"));
		
	}	
	public static String PlusTwoStrings(String strA, String strB) 
	{
			strA = ClearString(strA);
			strB = ClearString(strB);
			
			String result = new String("");
			String greater = GreaterString(strA, strB);
			String lower = strB;
			
			int top = 0;
			int bottom = 0;
			int remain = 0;
			int temp = 0;
			
	 		if (greater != strA) 
				lower = strA;
	 		
	 		int stringLengthGap  = greater.length() - lower.length();
			top = greater.length() - 1;
			bottom = lower.length() - 1; 
				
			for (int i =  top ; i >= stringLengthGap; i--) {
				int tempIntTop = (greater.charAt(i) - '0');
				int tempIntBottom = (lower.charAt(i - stringLengthGap) - '0');
				temp = tempIntTop + tempIntBottom + remain;
				if (temp >= 10) 
				{
					result =  (temp % 10) + result;
					remain = 1;
				}
				else 
				{
					result =   temp + result;
					remain = 0;
				}
			}
			
			for (int i = stringLengthGap - 1; i >= 0; i--) {
				 temp = greater.charAt(i) - '0' + remain;
				
				if (temp >= 10) 
				{
					result = temp % 10 + result;
					remain = 1;
				}
				else
				{ 
					result = temp + result;
					remain = 0;
				}
			}
			
			if (remain == 0)
				return result;
			else 
				result = remain + result;
			
		return result;
	}
	
	public static String MinusTwoStrings(String strA, String strB) 
	{
			strA = ClearString(strA);
			strB = ClearString(strB);
			
			String result = new String("");
			String greater = GreaterString(strA, strB);
			String lower = strB;
			
			int top = 0;
			int bottom = 0;
			int remain = 0;
			int temp = 0;
			
	 		if (greater != strA) 
				lower = strA;
	 		
	 		int stringLengthGap  = greater.length() - lower.length();
			top = greater.length() - 1;
			bottom = lower.length() - 1; 
				
			for (int i =  top ; i >= stringLengthGap; i--) {
				int tempIntTop = (greater.charAt(i) - '0');
				int tempIntBottom = (lower.charAt(i - stringLengthGap) - '0');
				temp = tempIntTop - tempIntBottom;
				if (temp < 0) 
				{
					result =  ((tempIntTop + 10) - tempIntBottom - remain)  % 10 + result;
					remain = 1;
				}
				else 
				{
					result =   (tempIntTop - tempIntBottom - remain)  + result;
					remain = 0;
				}
			}
			
			for (int i = stringLengthGap - 1; i >= 0; i--) {
				temp = greater.charAt(i) - '0' - remain;
				
				if (temp < 0) 
				{
					result = ((greater.charAt(i) - '0' + 10)  - remain) % 10 + result;
					remain = 1;
				}
				else
				{ 
					result = (greater.charAt(i) - '0' - remain ) + result;
					remain = 0;
				}
			}
			return ClearString(result);
	}
		
	public static String ClearString(String str)
	{
		String result = new String("");
		boolean IsNegative = false;
		boolean IsClean = true;
		boolean IsZero = true;
		
		int lastZero = 0;
		
		for (int i = 0; i < str.length(); i++) {
			if (str.charAt(i) - '0' != 0) {
				IsZero = false;
			}
		}
		
		for (int i = 0; i < str.length(); i++) {
			if (Character.toString(str.charAt(i)).equals("0") == true) 
			{	
				lastZero = i;
				IsClean = false;
			}
			else if (Character.toString(str.charAt(i)).equals("-") == true) {
				IsNegative = true;
				lastZero = i;
			}
			else
				break;
		}
		
		if (IsNegative == true) 
			result = "-" + result;
		else if(IsClean == true)
			return result = str;
		else if(IsZero == true)
			return result = "0";
		
		//build string if fault string detected
		for (int i = lastZero + 1; i < str.length() ; i++) {
			result = result + (Character.toString(str.charAt(i)));
		}
		return result;
		
	}
		
	public static String FillString(String str, int gap) {
		
		String result = new String("");
		result = str;
		for (int i = 0; i < gap ; i++) {
			result = "0" + result;
		}
		return result;
	}
	
	public static String GreaterString(String strGreater, String strLower)
	{
		strGreater = ClearString(strGreater);
		strLower = ClearString(strLower);
		
		boolean flag = true;
		int lengthGreater = strGreater.length();
		int lengthLower = strLower.length();
		
		if (strGreater.charAt(0) == '-' && strLower.charAt(0) != '-') 
		{
			return strLower;
		}
		else if (strGreater.charAt(0) != '-' && strLower.charAt(0) != '-' && lengthGreater < lengthLower ) {
			return strLower;
		}
		else if (strGreater.charAt(0) != '-' && strLower.charAt(0) != '-' && lengthGreater > lengthLower ) {
			return strGreater;
		}
		else if (strGreater.charAt(0) == '-' && strLower.charAt(0) == '-' && lengthGreater > lengthLower ) {
			return strLower;
		}
		else if (strGreater.charAt(0) == '-' && strLower.charAt(0) == '-' && lengthGreater < lengthLower ) {
			return strGreater;
		}
		else if (strGreater.charAt(0) == '-' && strLower.charAt(0) == '-' && lengthGreater == lengthLower ) {
			for (int i = 1; i < lengthGreater; i++) {
					if (strGreater.charAt(i) - '0' > strLower.charAt(i) - '0') {
						flag = false;
						break;
					}
					else if (strGreater.charAt(i) - '0' < strLower.charAt(i) - '0') {
						flag = true;
						break;
					};
					
			}
		}
		else if (strGreater.charAt(0) != '-' && strLower.charAt(0) != '-' && lengthGreater == lengthLower )  {
			for (int i = 0; i < lengthGreater; i++) {
				
				if (strGreater.charAt(i) - '0' < strLower.charAt(i) - '0') {
					flag = false;
					break;
				}
				else if (strGreater.charAt(i) - '0' > strLower.charAt(i) - '0') {
					flag = true;
					break;
				};
				
			}
		} 
	
		if (flag == true) {
			return strGreater;
		}
		else
			return strLower;
	}
	
	
	
	
	

	
	
}
