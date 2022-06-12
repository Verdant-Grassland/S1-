package homework1025.jbit;

import java.util.Scanner;

public class TestUser {

	public static void main(String[] args) {
		int i = 0;
		String userName;
		String password;
		Scanner input = new Scanner(System.in);
		for (i = 0 ; i < 3 ; i++) {
			System.out.println("请输入用户名:");
			userName = input.next();
			System.out.println("请输入密码:");
			password = input.next();
			if ("lingming".equals(userName) && "125325".equals(password)) {
				System.out.println("欢迎登录MyShopping系统！");
				break;
			}else{
				System.out.println("输入错误！您还有" + (2-i) + "次机会！\n");
				continue;
			}
		}
		if (i == 3) {
			System.out.println("对不起，您3次均输入错误！");
		}
	}
}
