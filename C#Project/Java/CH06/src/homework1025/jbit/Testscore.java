package homework1025.jbit;

import java.util.Scanner;

public class Testscore {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int count = 0;
		for(int i = 1 ; i <= 8 ; i++){
			System.out.println("输入第" + i + "个的成绩:");
			int student = input.nextInt();
			if(student >= 90){
				count++;
			}
		}
		System.out.println("超过90分的人数:" + count);
		System.out.println("百分比例数:" + count / 8.0 * 100 + "%");
	}
}
