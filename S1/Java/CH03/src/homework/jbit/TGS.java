package homework.jbit;

import java.util.Scanner;

public class TGS {

	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("����1��");
		int shu=input.nextInt();
		System.out.println("����2��");
		int shuan=input.nextInt();
		System.out.println("��������ӵĽ��"+(shu+shuan));
		System.out.println("����������Ľ��"+(shu-shuan));
		System.out.println("��������˵Ľ��"+(shu*shuan));
		System.out.println("����������Ľ��"+(shu/shuan));
		System.out.println("������ȡ�ڵĽ��"+(shu%shuan));

	}
}
