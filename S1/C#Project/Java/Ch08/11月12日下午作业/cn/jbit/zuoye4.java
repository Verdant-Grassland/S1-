package cn.jbit;

import java.util.Scanner;

public class zuoye4 {
	public static void main(){
		Scanner input=new Scanner(System.in);
		int st=0;
		int[] oo=new int[5];
		for(int gb=0;gb<oo.length;gb++){
			System.out.println("输入第"+(gb+1)+"个同学的成绩");
			oo[gb]=input.nextInt();
			st=st+oo[gb];
			if(oo[gb]>60){
			}
		}
		System.out.println("及格");
	}

}
