package cn.jbit;

import java.util.Scanner;

public class zuoye4 {
	public static void main(){
		Scanner input=new Scanner(System.in);
		int st=0;
		int[] oo=new int[5];
		for(int gb=0;gb<oo.length;gb++){
			System.out.println("�����"+(gb+1)+"��ͬѧ�ĳɼ�");
			oo[gb]=input.nextInt();
			st=st+oo[gb];
			if(oo[gb]>60){
			}
		}
		System.out.println("����");
	}

}
