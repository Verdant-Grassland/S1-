package homework.jbit;

import java.util.Scanner;

public class Customer {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("�����Ա�Ļ���:");
		int VIPprocal = input.nextInt();
		if(VIPprocal <=1000 && VIPprocal >= 100){
			System.out.println("�տ�");
		}else if(VIPprocal <=3000 && VIPprocal >= 1001){
			System.out.println("����");
		}else if(VIPprocal <=5000 && VIPprocal >= 3001){
			System.out.println("��");
		}
	}
}