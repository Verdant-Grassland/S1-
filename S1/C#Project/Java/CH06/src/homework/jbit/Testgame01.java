package homework.jbit;

import java.util.Scanner;

public class Testgame01 {
	
	public static void main(String[] args) {
		System.out.println("����������Ϸƽ̨> ��Ϸ�����");
		int game = 0;
		int dianji = 0;
		Scanner input = new Scanner(System.in);
		for (int i = 0 ; i < 4 ; i++) {
			System.out.println("�������"+(i+1)+"����Ϸ�ĵ����:");
			game = input.nextInt();
			if (dianji > 100) {
				game++;
			}
		}
		System.out.println("����ʴ���100����Ϸ����:"+game);
		System.out.println("����ʴ���100����Ϸ��ռ�ı���Ϊ:"+(game/4.0*100 +"%");
	}
}
