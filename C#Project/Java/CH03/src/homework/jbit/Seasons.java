package homework.jbit;

import java.util.Scanner;

public class Seasons {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("����һ���·ݣ�");
		int mo=input.nextInt();
		if(mo==3||mo==4||mo==5){
			System.out.println("����");
		}else if(mo==6||mo==7||mo==8){
			System.out.println("�ļ�");
		}else if(mo==9||mo==10||mo==11){
			System.out.println("�＾");
		}else{
			System.out.println("����");
		}
	}
}
