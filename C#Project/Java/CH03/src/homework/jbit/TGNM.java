package homework.jbit;

import java.util.Scanner;

public class TGNM {
	
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.print("�������м�����������");
		int score = input.nextInt();
		if(score>5){
			System.out.println("��Ҫȥ�˵���Щ����");
		}else if(score<5){
			System.out.println("��Ҫ�Ե���Щ����");
		}
		}
	}