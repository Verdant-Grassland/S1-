package CN.jbit;

import java.util.Scanner;

public class zy_1 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("一个四位数");
		Scanner input=new Scanner(System.in);
		int shu=input.nextInt();
		int qian=shu/1000%10;
		int bai=shu/100%10;
		int shi=shu/10%10;
		int ge=shu%10;
		System.out.println("千位"+qian);
		System.out.println("百位"+bai);
		System.out.println("十位"+shi);
		System.out.println("个位"+ge);
		
	}

}
