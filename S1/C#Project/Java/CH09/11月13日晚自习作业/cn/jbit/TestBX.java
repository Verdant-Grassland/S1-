package cn.jbit;

import java.util.Arrays;

public class TestBX {

	/**
	 * ��д����ʵ�ֽ�һ�������е���������ͽ������
	 */
	public static void main(String[] args) {
		int num[] = new int[]{159,486,426,827,913};
		System.out.print("ԭ˳��Ϊ:");
		for(int i=0;i<num.length;i++){
			System.out.print(num[i]+"\t");
			
		}
		System.out.print("\n�����:");
		Arrays.sort(num);
		for(int i=0;i<num.length;i++){
			System.out.print(num[i]+"\t");
		}
		System.out.print("\n�����:");
		for(int i=num.length-1;i>=0;i--){
			System.out.print(num[i]+"\t");
		}
	}
}
