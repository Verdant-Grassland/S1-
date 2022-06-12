package homework.jbit;

import java.util.Scanner;

public class SXH {
	
	public static void main(String[] args) {
		System.out.println("输入百位的数字:");
		Scanner input=new Scanner(System.in);
		int i=input.nextInt();
		int j=i/100%10;
		int kk=i/10%10;
		int ijk=i%10;
		int ik=j*j*j+kk*kk*kk+ijk*ijk*ijk;
		System.out.println("等于"+ik);
	}

}

