package homework.jbit;

import java.util.Scanner;

public class Testgame02 {
	
	public static void main(String[] args) {
		boolean flag;
		System.out.println("��ӭ����������Ϸ����Ϸƽ̨");
		System.out.println("��ѡ����ϲ������Ϸ:");
		System.out.println("***************************************************");
		System.out.println("1.������");
		System.out.println("2.��ţ");
		System.out.println("3.������");
		System.out.println("4.������");
		System.out.println("***************************************************");
		Scanner input = new Scanner(System.in);
		System.out.println("��ѡ����������:");
		int num = input.nextInt();
		do {
			flag = false;
			switch(num){
			case 1:
				System.out.println("���Ѿ����붷��������");
				break;
			case 2:
				System.out.println("���Ѿ����붷ţ����");
				break;
			case 3:
				System.out.println("���Ѿ���������������");
				break;
			case 4:
				System.out.println("���Ѿ���������������");
				break;
			default:
				System.out.print("��������������������֣�");
				num = input.nextInt();
				flag = true;
				break;
			}
		}while(flag);
	}
}
