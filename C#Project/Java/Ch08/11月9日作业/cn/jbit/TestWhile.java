package cn.jbit;

public class TestWhile {

	public static void main(String[] args) {
		int sum = 0;
		int i = 1;
		while(i <= 200){
			if(i%3 == 0){
				sum += i;
			}
			i++;
		}
		System.out.println(sum);
	}
}
