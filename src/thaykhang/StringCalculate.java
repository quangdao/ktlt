package thaykhang;

import java.util.stream.Stream;

import javax.swing.text.StyledEditorKit.ForegroundAction;

import org.omg.CORBA.PUBLIC_MEMBER;

import com.sun.javafx.scene.layout.region.Margins.Converter;
import com.sun.org.apache.xalan.internal.xsltc.compiler.Template;

import sun.net.TelnetOutputStream;

public class StringCalculate {

	
	
	
//	public static String Plus2Strings(String strA, String strB)
//	{
//
//		int lengthA = strA.length();
//		int lengthB = strB.length();
//		int lengthOfResult = 0;
//		
//		if ( lengthA > lengthB) {
//			lengthOfResult = strA.length();
//			for (int i = 0; i < lengthA - lengthB ; i++) {
//				strB = "0" + strB;
//			}
//		}
//		else {
//			lengthOfResult = strB.length();
//			for (int i = 0; i < lengthB - lengthA; i++) {
//				strA = "0" + strA;
//			}
//		}
//		int tempStrA = 0;
//		int tempStrB = 0;
//		int remain = 0;
//		String result = new String("");
//		for (int i = lengthOfResult - 1; i >= 0; i--) 
//		{
//			tempStrA = strA.charAt(i) - '0';
//			tempStrB = strB.charAt(i) - '0';
//			int tempInt = tempStrA + tempStrB + remain;
//			if (tempInt >= 10) {
//				remain = 1;
//				result =  tempInt % 10 + result ;
//			}
//			else {
//				result =  tempInt + result;
//				remain = 0;
//			}
//		}
//		if (remain != 0) {
//			result = remain + result;
//		}
//		return  result;
//	}
//	
	
//	public static String Minus2Strings(String strA, String strB)
//	{
//		
//		strA = ClearString(strA);
//		strB = ClearString(strB);
//		String result = new String("");
//		String greater = new String("");
//		String lower = new String("");
//		
//		if (IsGreaterString(strA,strB) == true) {
//			greater = strA;
//			lower = FillString(strB, greater.length() - strB.length());
//		}
//		else {
//			greater = strB;
//			//result = result = "-";
//			lower = FillString(strA, greater.length() - strA.length());
//		}
//		
//		int lengthOfResult = greater.length();
//		int tempStrGreater = 0;
//		int tempStrLower = 0;
//		int remain = 0;
//		
//		for (int i = lengthOfResult - 1; i >= 0; i--) 
//		{
//			tempStrGreater = greater.charAt(i) - '0';
//			tempStrLower = lower.charAt(i) - '0';
//			int temp = 0;
//			if (tempStrGreater < tempStrLower ) {
//				temp = (tempStrGreater + 10) - tempStrLower - remain;
//				result =  temp + result;
//				remain = 1;
//			}
//			else {
//				temp = tempStrGreater - tempStrLower - remain;
//				result = temp + result;
//				remain = 0;
//			}
//		}
//		
//		if (greater != strA) {
//			result = "-" + result;
//		}
//		return  result;
//	}
	public static void main(String[] args) {
		
		System.out.print(PlusTwoStrings("45","17"));
		//System.out.print(GreaterString("-610","-610"));
//System.out.print(ClearString("0-0-0-0-0-0-0-00000----000000003870"));

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
//		if (stringLengthGap == 0 ) 
//		{
//			for (int i = greater.length() - 1 ; i >= 0 ; i--)
//			{
//				int tempIntTop = (greater.charAt(i) - '0');
//				int tempIntBottom = (lower.charAt(i) - '0');
//				temp = tempIntTop + tempIntBottom + remain;
//				if (temp >= 10) 
//				{
//					result =  (temp % 10) + result;
//					remain = 1;
//				}
//				else 
//				{
//					result =   temp + result;
//					remain = 0;
//				}
//					
//			}
//			if (remain == 0)
//				return result;
//			else 
//				result = remain + result;
//		}
		//!= Length
		//else if (stringLengthGap != 0) {
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
				if (remain == 0)
					 result = (greater.charAt(i) - '0') + result;
				else 
				{ 
					result = (greater.charAt(i) - '0' + remain) + result;
					remain = 0;
				}
			}
		//}
			if (remain == 0)
				return result;
			else 
				result = remain + result;
		return result;
}
	
	public static String ClearString(String str)
	{
		String result = new String("");
		boolean IsNegative = false;
		boolean IsClean = true;
		int lastZero = 0;
		
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
