package homework.jbit;

import java.util.Scanner;

public class MQS {
	
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("输入星期数字：");
		int num=input.nextInt();
		if(num==1){
			System.out.println("星期一");
		}else if(num==2){
			System.out.println("星期二");
		}else if(num==3){
			System.out.println("星期三");
		}else if(num==4){
			System.out.println("星期四");
		}else if(num==5){
			System.out.println("星期五");
		}else if(num==6){
			System.out.println("星期六");
		}else if(num==7){
			System.out.println("星期七");
		}
	}
}
