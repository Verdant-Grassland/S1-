package homework.jbit;

import java.util.Scanner;

public class Seasons {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("输入一个月份：");
		int mo=input.nextInt();
		if(mo==3||mo==4||mo==5){
			System.out.println("春季");
		}else if(mo==6||mo==7||mo==8){
			System.out.println("夏季");
		}else if(mo==9||mo==10||mo==11){
			System.out.println("秋季");
		}else{
			System.out.println("冬季");
		}
	}
}
