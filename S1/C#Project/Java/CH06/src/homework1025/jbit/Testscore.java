package homework1025.jbit;

import java.util.Scanner;

public class Testscore {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int count = 0;
		for(int i = 1 ; i <= 8 ; i++){
			System.out.println("�����" + i + "���ĳɼ�:");
			int student = input.nextInt();
			if(student >= 90){
				count++;
			}
		}
		System.out.println("����90�ֵ�����:" + count);
		System.out.println("�ٷֱ�����:" + count / 8.0 * 100 + "%");
	}
}
