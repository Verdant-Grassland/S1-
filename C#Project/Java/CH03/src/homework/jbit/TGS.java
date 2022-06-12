package homework.jbit;

import java.util.Scanner;

public class TGS {

	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("数字1：");
		int shu=input.nextInt();
		System.out.println("数字2：");
		int shuan=input.nextInt();
		System.out.println("两个数相加的结果"+(shu+shuan));
		System.out.println("两个数相减的结果"+(shu-shuan));
		System.out.println("两个数相乘的结果"+(shu*shuan));
		System.out.println("两个数相除的结果"+(shu/shuan));
		System.out.println("两个数取于的结果"+(shu%shuan));

	}
}
