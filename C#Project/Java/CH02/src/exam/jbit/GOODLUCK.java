package exam.jbit;

import java.util.Scanner;

public class GOODLUCK {

	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("输入4位的会员卡号：");
		int num=input.nextInt();
		int qianWei=num/1000;
		int baiWei=num/100%10;
		int shiWei=num/10%10;
		int geWei=num%10;
		
		int sum=qianWei+baiWei+shiWei+geWei;
		
		System.out.println("会员卡号"+num+"各个位数之和是:"+sum);
		System.out.println("是幸运客户吗？"+(sum>20));
	}
}
