package cn.jbit;

import java.util.Scanner;

public class Demo {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		CurrentTime currentTime = new CurrentTime();
		currentTime.CurTime = "2015年5月12日10点11分30秒";
		currentTime.show();
		
		System.out.print("输入修改后的时间为:");
		currentTime.CurTime = input.next();
		System.out.println("修改完成");
		currentTime.show();
	}
}
