package homework.jbit;

import java.util.Scanner;

public class QXT {
	
	public static void main(String[] args) {
		System.out.println("*******************��ӭ����ѧϰ����ϵͳ********************");
		System.out.println("\t\t\t1.��¼ϵͳ");
		System.out.println("\t\t\t2.�˳�");
		System.out.println("*************************************************************");
		System.out.println("��ѡ����������:");
		Scanner input = new Scanner (System.in);
		if(input.hasNext()==true){
			int num = input.nextInt();
			switch (num){
				case 1:
					System.out.println("*******************���˵�********************");
					System.out.println("\t\t\t1.Javaѧϰ");
					System.out.println("\t\t\t2.HTML��ҳ���");
					System.out.println("\t\t\t3.SQL���ݿ����");
					System.out.println("*********************************************");
					break;
				case 2:
					System.out.println("�˳�ϵͳ��лл����ʹ�ã�");
				    break;
			}
		}
	}
}
