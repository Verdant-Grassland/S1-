package cn.jbit;

import java.util.Scanner;

public class TestAnd {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入一行字符:");
		String line = input.nextLine();
		char[] chs = line.toCharArray();
		int[] count = new int[4];
		for(int i = 0; i<chs.length ; i++){
			if((chs[i] >= 'A' && chs[i] <= 'Z') || (chs[i] >= 'a' && chs[i] <= 'z')){
				count[0]++;
			}else if(chs[i] >= '0' && chs[i] <= '9'){
				count[1]++;
			}else if(chs[i] == ' '){
				count[2]++;
			}else{
				count[3]++;
			}
		}
		System.out.println("英文字母的个数是:" + count[0]);
		System.out.println("数字的个数是:" + count[1]);
		System.out.println("空格的个数是:" + count[2]);
		System.out.println("其它字符的个数是:" + count[3]);
	}
}
