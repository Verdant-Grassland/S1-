package cn.jbit;

public class Calculator {
	double sum = 0;
	double num = 0;
	public void show(){
		System.out.println("���������Ϊ:" + (sum + num));
		System.out.println("���������Ϊ:" + (sum - num));
		System.out.println("���������Ϊ:" + (sum * num));
		System.out.println("����������Ϊ:" + (sum / num));
	}
}
