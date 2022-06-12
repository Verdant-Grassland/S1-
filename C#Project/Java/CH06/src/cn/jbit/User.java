package cn.jbit;
import java.util.Scanner;


public class User {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		for (int i = 1 ; i <= 3 ; i++) {
			System.out.println("\n请输入会员号:");
			int userNo = input.nextInt();
			if (userNo < 1000 || userNo > 9999) {
				System.out.println("不是合法会员号,会员号码必须是4位");
				continue;
			}
			System.out.println("请输入会员生日:");
			String birthday = input.next();
			System.out.println("请输入会员的积分:");
			int point = input.nextInt();
			System.out.println("您录入的会员信息是:");
			System.out.println(userNo + "\t" + birthday + "\t" + point);
		}
	}
}
