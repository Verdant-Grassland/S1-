package homework1025.jbit;

import java.util.Scanner;

public class TestUser {

	public static void main(String[] args) {
		int i = 0;
		String userName;
		String password;
		Scanner input = new Scanner(System.in);
		for (i = 0 ; i < 3 ; i++) {
			System.out.println("�������û���:");
			userName = input.next();
			System.out.println("����������:");
			password = input.next();
			if ("lingming".equals(userName) && "125325".equals(password)) {
				System.out.println("��ӭ��¼MyShoppingϵͳ��");
				break;
			}else{
				System.out.println("�������������" + (2-i) + "�λ��ᣡ\n");
				continue;
			}
		}
		if (i == 3) {
			System.out.println("�Բ�����3�ξ��������");
		}
	}
}
