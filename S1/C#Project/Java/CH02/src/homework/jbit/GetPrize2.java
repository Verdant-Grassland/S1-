package homework.jbit;

public class GetPrize2 {
	
	public static void main(String[] args) {
		int score1 = 100;
		int score2 = 72;
		if((score1>98&& score2>80)
			||(score1 == 100 && score2>70)){
			System.out.println("老师说：不错，奖励一个MP4！");
		}
	}

}
