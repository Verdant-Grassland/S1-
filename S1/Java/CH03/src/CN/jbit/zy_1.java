package CN.jbit;

import java.util.Scanner;

public class zy_1 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("һ����λ��");
		Scanner input=new Scanner(System.in);
		int shu=input.nextInt();
		int qian=shu/1000%10;
		int bai=shu/100%10;
		int shi=shu/10%10;
		int ge=shu%10;
		System.out.println("ǧλ"+qian);
		System.out.println("��λ"+bai);
		System.out.println("ʮλ"+shi);
		System.out.println("��λ"+ge);
		
	}

}
