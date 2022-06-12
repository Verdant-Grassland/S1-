package 十一月十三日下午考试;

import java.util.Scanner;

public class TestCalc00 {

	/**
	 * 菜单切换
	 */
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("*************欢迎青鸟学习系统*************");
		System.out.println("1.java学习");
		System.out.println("2.html网页设计");
		System.out.println("3.sql数据库基础");
		System.out.println("4.注销");
		System.out.println("*************************************");
		System.out.println("请选择数字:");
		int num = input.nextInt();
		boolean flag;
		do{
			flag = false;
			switch(num){
			case 1:
				System.out.println("执行java学习");
				break;
			case 2:
				System.out.println("执行html网页设计");
				break;
			case 3:
				System.out.println("sql数据库基础");
				break;
			case 4:
				System.out.println("注销");
				break;
			default:
				System.out.println("输入不正确，请重新输入选择数字:");
				num = input.nextInt();
				flag = true;
			}
		}while(flag);
	}
}
