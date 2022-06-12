package cn.jbit;

import java.util.Arrays;

public class TestBX {

	/**
	 * 编写程序，实现将一个数组中的数据升序和降序输出
	 */
	public static void main(String[] args) {
		int num[] = new int[]{159,486,426,827,913};
		System.out.print("原顺序为:");
		for(int i=0;i<num.length;i++){
			System.out.print(num[i]+"\t");
			
		}
		System.out.print("\n升序后:");
		Arrays.sort(num);
		for(int i=0;i<num.length;i++){
			System.out.print(num[i]+"\t");
		}
		System.out.print("\n降序后:");
		for(int i=num.length-1;i>=0;i--){
			System.out.print(num[i]+"\t");
		}
	}
}
