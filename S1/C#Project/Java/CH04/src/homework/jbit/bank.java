package homework.jbit;

import java.util.Scanner;

public class bank {
	
	public static void main(String[] args) {
		  Scanner input = new Scanner(System.in);
		  System.out.println("�����뱾��");
		  double pri_amt=Double.parseDouble(input.next());
		  double tot_amt=0;
		  double rate1y = 2.25/100;
		  double rate2y = 2.7/100;
		  double rate3y = 3.24/100;
		  double rate5y = 3.6/100;
		  double interest;
		  
		  System.out.println("����Ϊ�� "+pri_amt);
		  interest = pri_amt*rate1y*1;
		  tot_amt = pri_amt+interest;
		  System.out.println("\n��ȡһ���ı�Ϣ�ǣ� "+tot_amt);
		  
		  interest = pri_amt*rate2y*2;
		  tot_amt = pri_amt+interest;
		  System.out.println("\n��ȡ�����ı�Ϣ�ǣ� "+tot_amt);
		  
		  interest = pri_amt*rate3y*3;
		  tot_amt = pri_amt+interest;
		  System.out.println("\n��ȡ�����ı�Ϣ�ǣ� "+tot_amt);
		  
		  interest = pri_amt*rate5y*5;
		  tot_amt = pri_amt+interest;
		  System.out.println("\n��ȡ�����ı�Ϣ�ǣ� "+tot_amt);
	}
}