package homework.jbit;

import java.util.Scanner;

public class Console1 {
	
	public static void main(String[] args) {
		int random = (int) (Math.random()*10);
		System.out.println("�������ع������ϵͳ > ���˳齱\n");
		System.out.print("������4λ��Ա�ţ� ");
		Scanner input=new Scanner(System.in);
		int custNo = input.nextInt();
		int baiwei = custNo/100%10;
		if (baiwei == random) {
			System.out.println(custNo +"�����˿ͻ�������Mp3һ����");
		}else{
			System.out.println(custNo +"лл����֧�֣�");
		}
	}
}   