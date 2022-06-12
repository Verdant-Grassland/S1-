package nighthomework.jbit;

import java.util.Scanner;

public class TestOut {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int x = input.nextInt();
		int y = -1;
		if(x>0){
			y = 1;
		}
		else if(x==0){
			y = 0;
		}
		else{
			y = -1;
		}
		System.out.println(y);
	}
}
