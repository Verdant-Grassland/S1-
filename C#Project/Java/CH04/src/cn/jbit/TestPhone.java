package cn.jbit;
import java.util.Scanner;

public class TestPhone {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("���벦�����֣�");
		int Bohao=input.nextInt();
		switch(Bohao){
		case 1:
			System.out.println("���ְֵĺ�");
			break;
		case 2:
			System.out.println("������ĺ�");
			break;
		case 3:
			System.out.println("��үү�ĺ�");
			break;
		case 4:
			System.out.println("�����̵ĺ�");
			break;
		 default:
				break;
		}
	}
}
