package homework.jbit;

import java.util.Scanner;

public class QXT {
	
	public static void main(String[] args) {
		System.out.println("*******************欢迎青鸟学习管理系统********************");
		System.out.println("\t\t\t1.登录系统");
		System.out.println("\t\t\t2.退出");
		System.out.println("*************************************************************");
		System.out.println("请选择，输入数字:");
		Scanner input = new Scanner (System.in);
		if(input.hasNext()==true){
			int num = input.nextInt();
			switch (num){
				case 1:
					System.out.println("*******************主菜单********************");
					System.out.println("\t\t\t1.Java学习");
					System.out.println("\t\t\t2.HTML网页设计");
					System.out.println("\t\t\t3.SQL数据库基础");
					System.out.println("*********************************************");
					break;
				case 2:
					System.out.println("退出系统，谢谢您的使用！");
				    break;
			}
		}
	}
}
