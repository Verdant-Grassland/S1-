package cn.jbit;

public class Data {
	int sum;
	public void swap(int num1 , int num2){
		System.out.println("交换前:" + num1 + "\t" + num2);
		sum = num1;
		num1 = num2;
		num2 = sum;
		System.out.println("交换后:" + num1 + "\t" + num2);
	}
}
