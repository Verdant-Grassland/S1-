package CN.jbit;

import java.util.Scanner;

public class ZY_3 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("输入一个数");
		Scanner input=new Scanner(System.in);
		int shu=input.nextInt();
		System.out.println("输入第二个数");
		int su=input.nextInt();
		System.out.println("加"+(shu+su));
		System.out.println("减"+(shu-su));
		System.out.println("乘"+(shu*su));
		System.out.println("除"+(shu/su));
		System.out.println("余"+(shu%su));
		
	}

}
