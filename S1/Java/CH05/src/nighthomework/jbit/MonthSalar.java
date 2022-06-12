package nighthomework.jbit;

import java.util.Scanner;

public class MonthSalar {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("请输入您的月薪以算您应交胡个人所得税:");
		double in = input.nextInt();
		double a = 0;
		if(in <= 850){
			a = in * 1;
		}
		else if(in > 850 && in <= 1350){
			a = (in - 850) * 0.05;
		}
		else if(in > 1350 && in <= 2850){
			a = (in - 850) * 0.1;
		}
		else if(in > 2850 && in <= 5850){
			a = (in - 850) * 0.15;
		}
		else if(in > 5850 ){
			a = (in - 850) * 0.25;
		}
		System.out.println("应交胡个人所得税"+a+"元");
	}
}
