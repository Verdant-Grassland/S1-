package homework1025.jbit;

import java.util.Scanner;

public class Testnumber {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int sum = 0;
		int count = 0;
		for (int i = 1 ; i <= 10 ; i++){
			System.out.println("�����"+ i + "����:");
			int num = input.nextInt();
			if(num == 999){
				break;
			}
			if(num > 0){
				sum = sum + num;
				count++;
			}
		}
		System.out.println("�ۼӺ�:" + sum);
		System.out.println("����:" + count);
	}
}