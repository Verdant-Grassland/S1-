package cn.jbit;

import java.util.Arrays;

public class TestProgram {

	public static void main(String[] args) {
		System.out.print("打分排序前" + "\t");
		int[] nore = new int[]{10,25,36,74,86,93};
		for(int i = 0 ; i<nore.length ; i++){
			System.out.print(nore[i] + "分" + "\t");
		}
		Arrays.sort(nore);
		for(int i = 0 ; i<nore.length ; i++){
		}
		int[] nores = new int[]{0};
		nores[0] = nore[1] + nore[2]+ nore[3];
		System.out.println("\n" + "最后的得分" + nores[0] + "分");
	}
}
