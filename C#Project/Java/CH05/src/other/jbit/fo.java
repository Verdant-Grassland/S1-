package other.jbit;

import java.util.Scanner;

public class fo {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int i = 10;
		int i2 = 10;
		double i1 = 5;
		double i3 = 5;
		System.out.println(i+i2/i+i3+"��");
		while(i <= 100) {
			i = i+i2;
			i3 = i3+2;
		}
		System.out.println("ţƤ�·�"+i+"Ԫ");
		System.out.println("����ţƤ�·�"+i3+"Ԫ");
		System.out.println("�ܼ�:"+(i+i3)*0.16);
		System.out.println("����"+i1+i2+"����");
		System.out.println("�ܼۣ�"+i+i2/i+i3+"����"+i1+i2+i3+"����");
	}
}
