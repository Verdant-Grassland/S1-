package cn.jbit;

import java.util.Scanner;

public class shop {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("�Ƿ��ǻ�Ա(y/n)");
		String user=input.next();
		System.out.println("���빺���");
		double money=input.nextDouble();
		
		if(user.equals("y")){
			if(money>=200){
				money=money*0.75;
			}else{
				money=money*0.8;
			}
		}else{
			if(money>=100){
				money=money*0.9;
			}
		}
		System.out.println("ʵ��֧����"+money);
	}
}
