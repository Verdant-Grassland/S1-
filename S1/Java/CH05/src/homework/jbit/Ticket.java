package homework.jbit;

import java.util.Scanner;

public class Ticket {
	
	public static void main(String[] args) {
		System.out.println("����Ǯ��:");
		int i = new Scanner(System.in).nextInt();
		if (i >= 20 && i <= 60){
            System.out.println("Ӳ��");
        }else if (i >= 120 && i <= 200){
            System.out.println("����");
        }else if (i >= 240 && i <= 300){
            System.out.println("����Ʊ");
        }
    }
}