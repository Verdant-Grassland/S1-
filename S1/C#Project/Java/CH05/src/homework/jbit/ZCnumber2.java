package homework.jbit;

import java.util.Scanner;

public class ZCnumber2 {
	
	public static void main(String[] args) {
		for (int i = 1 ; i <= 1000 ; i++){
            if (i%7 == 0 && i%3 == 0){
                System.out.println(i);
            }
        }
    }
}
