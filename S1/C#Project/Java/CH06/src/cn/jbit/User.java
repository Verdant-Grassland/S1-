package cn.jbit;
import java.util.Scanner;


public class User {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		for (int i = 1 ; i <= 3 ; i++) {
			System.out.println("\n�������Ա��:");
			int userNo = input.nextInt();
			if (userNo < 1000 || userNo > 9999) {
				System.out.println("���ǺϷ���Ա��,��Ա���������4λ");
				continue;
			}
			System.out.println("�������Ա����:");
			String birthday = input.next();
			System.out.println("�������Ա�Ļ���:");
			int point = input.nextInt();
			System.out.println("��¼��Ļ�Ա��Ϣ��:");
			System.out.println(userNo + "\t" + birthday + "\t" + point);
		}
	}
}
