package ʮһ��ʮ�������翼��;

public class TestSum00 {

	/**
	 * ����100���ڵ�ż��֮��
	 */
	public static void main(String[] args) {
		int sum = 0;
		int num = 0;
		while(num >= 100){
			sum = sum + num;
			num = num + 2;
		}
		System.out.println("100���ڵ�ż��֮��Ϊ:" + sum);
	}
}
