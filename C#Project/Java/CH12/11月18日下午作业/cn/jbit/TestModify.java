package cn.jbit;

public class TestModify {

	/**
	 * 5.
	 */
	public static void main(String[] args) {
		int[] num = new int[]{1,3,-1,5,-2};
		int[] Butter = new int[5];
		System.out.println("原数组为：");
		for(int i = 0; i < num.length; i++){
			System.out.print(num[i] + " ");
		}
		for(int i = 0; i < Butter.length; i++){
			if(num[i] < 0){
				num[i] = 0;
			}
			Butter[i] = num[i];
		}
		System.out.println("\n逆序并处理后的数组为：");
		for(int i = num.length-1; i >= 0; i--){
			System.out.print(Butter[i] + " ");
		}
	}
}
