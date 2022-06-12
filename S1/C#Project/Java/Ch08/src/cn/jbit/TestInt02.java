package cn.jbit;

public class TestInt02 {

	public static void main(String[] args) {
		int []num = new int[]{8,4,2,1,23,344,12};
		int sum = 0;
		for (int i = 0; i<num.length ; i++) { 
			sum = sum + num[i];
		}
		System.out.println("ºÍÊÇ:" + sum);
	}
}