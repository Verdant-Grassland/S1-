package cn.jbit;

public class TestCalc {

	public static void main(String[] args) {
		int num = 0;
		for(int i = 1 ; i <= 100 ; i++){
			if(i%3 != 0){
			num = num + i;
			if(num >= 2000){
				System.out.println("这个数字是：" + num);
				}
			}
		}
	}
}
