package CN.jbit;

import java.util.Scanner;

public class ZY_4 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("小明买一筐鸡蛋");
		System.out.println("坏了的有几个");
		Scanner input=new Scanner(System.in);
		int hui=input.nextInt();
		if (hui<=5){
			System.out.println("小明就吃掉");
		}else{
			System.out.println("去退货");
		}
	}

}
