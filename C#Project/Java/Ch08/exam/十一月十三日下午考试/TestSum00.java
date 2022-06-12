package 十一月十三日下午考试;

public class TestSum00 {

	/**
	 * 计算100以内的偶数之和
	 */
	public static void main(String[] args) {
		int sum = 0;
		int num = 0;
		while(num >= 100){
			sum = sum + num;
			num = num + 2;
		}
		System.out.println("100以内的偶数之和为:" + sum);
	}
}
