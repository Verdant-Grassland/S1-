package homework.jbit;

import java.util.Scanner;

public class Console02 {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("����С�������յ�ѹ��Ǯ����");
		int score = input.nextInt();
		if (score == 1000){
			System.out.println("������ʧѧ��ͯ");
		}else if (score < 1000 && score >= 500){
			System.out.println("������ģ");
		}else if (score < 500){
			System.out.println("������ٿ�ȫ��");
		}
	}

}
