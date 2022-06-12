package homework.jbit;

import java.util.Scanner;

public class Drink {
	
	public static void main(String[] args) {
		System.out.println("ÊäÈëÒûÁÏÀàĞÍ£º");
        String s = new Scanner(System.in).nextLine();
        if (s.equals("¿§·È")){
            System.out.println("¿àÅ£");
        }else if (s.equals("ÄÌ")){
            System.out.println("Ìğ");
        }else if (s.equals("ÄûÃÊ")){
            System.out.println("Ëá");
        }
    }
}
