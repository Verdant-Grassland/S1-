package homework.jbit;

import java.util.Scanner;

public class Ticket {
	
	public static void main(String[] args) {
		System.out.println("ÊäÈëÇ®Êý:");
		int i = new Scanner(System.in).nextInt();
		if (i >= 20 && i <= 60){
            System.out.println("Ó²×ù");
        }else if (i >= 120 && i <= 200){
            System.out.println("¶¯³µ");
        }else if (i >= 240 && i <= 300){
            System.out.println("ÎÔÆÌÆ±");
        }
    }
}