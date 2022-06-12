package cn.jbit;

import java.util.Scanner;

public class Translator {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("* * * * * *欢迎使用Mini软换器* * * * * *");
		boolean weather = false;
		while(!weather){
			System.out.println("请输入天气状况的第一个英文字母:");
			char letter = input.next().charAt(0);
			switch(letter){
			case 'D':
				System.out.println("干躁");
				break;
			case 'M':
				System.out.println("潮湿");
				break;
			case 'H':
				System.out.println("炎热");
				break;
			case 'R':
				System.out.println("下雨");
				break;
			default:
				System.out.println("输入错误，无法转换");
				break;
			}
			System.out.println("您想继续吗？（y/n）");
			char junxian = input.next().charAt(0);
			if(junxian == 'n'){
				weather = false;
				System.out.println("退出系統");
				break;
			}
		}weather = true;
	}
}
