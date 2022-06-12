package homework.jbit;

import java.util.Scanner;

public class Testgame01 {
	
	public static void main(String[] args) {
		System.out.println("青鸟迷你游戏平台> 游戏点击率");
		int game = 0;
		int dianji = 0;
		Scanner input = new Scanner(System.in);
		for (int i = 0 ; i < 4 ; i++) {
			System.out.println("请输入第"+(i+1)+"个游戏的点击率:");
			game = input.nextInt();
			if (dianji > 100) {
				game++;
			}
		}
		System.out.println("点击率大于100的游戏数是:"+game);
		System.out.println("点击率大于100的游戏所占的比例为:"+(game/4.0*100 +"%");
	}
}
