package nighthomework.jbit;

public class TestNumber {
	
	public static void main(String[] args) {
		
		for(int i = 1; i <= 100 ; i++){
			int ge = i % 10;
			int shi = i / 10;
		if (ge*ge*ge+shi*shi*shi==i){
				System.out.println(i);
			}
		}
	}
}
	
 