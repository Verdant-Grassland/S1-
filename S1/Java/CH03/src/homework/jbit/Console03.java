package homework.jbit;

import java.util.Scanner;

public class Console03 {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("�������֣�");
		int score=input.nextInt();
		if(score<7){
			System.out.println("��ȥ����");
		}else{
			System.out.println("�ڼ���Ϣ");
		}
	}
}
