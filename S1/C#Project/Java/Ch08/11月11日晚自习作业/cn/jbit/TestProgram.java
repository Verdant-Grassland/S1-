package cn.jbit;

import java.util.Arrays;

public class TestProgram {

	public static void main(String[] args) {
		System.out.print("�������ǰ" + "\t");
		int[] nore = new int[]{10,25,36,74,86,93};
		for(int i = 0 ; i<nore.length ; i++){
			System.out.print(nore[i] + "��" + "\t");
		}
		Arrays.sort(nore);
		for(int i = 0 ; i<nore.length ; i++){
		}
		int[] nores = new int[]{0};
		nores[0] = nore[1] + nore[2]+ nore[3];
		System.out.println("\n" + "���ĵ÷�" + nores[0] + "��");
	}
}
