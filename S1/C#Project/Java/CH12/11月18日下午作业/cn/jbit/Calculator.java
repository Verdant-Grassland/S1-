package cn.jbit;

public class Calculator {
	double sum = 0;
	double num = 0;
	public void show(){
		System.out.println("两个数相加为:" + (sum + num));
		System.out.println("两个数相减为:" + (sum - num));
		System.out.println("两个数相乘为:" + (sum * num));
		System.out.println("两个数相余为:" + (sum / num));
	}
}
