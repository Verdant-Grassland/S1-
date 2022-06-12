package cn.jbit;
import java.util.Scanner;

public class TestPhone {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("ÊäÈë²¦ºÅÊı×Ö£º");
		int Bohao=input.nextInt();
		switch(Bohao){
		case 1:
			System.out.println("²¦°Ö°ÖµÄºÅ");
			break;
		case 2:
			System.out.println("²¦ÂèÂèµÄºÅ");
			break;
		case 3:
			System.out.println("²¦Ò¯Ò¯µÄºÅ");
			break;
		case 4:
			System.out.println("²¦ÄÌÄÌµÄºÅ");
			break;
		 default:
				break;
		}
	}
}
