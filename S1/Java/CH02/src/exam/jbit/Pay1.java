package exam.jbit;

import java.util.Scanner;

public class Pay1 {
	
	public static void main(String[] args) {
		int shirtPrice=250;
		int shoePrice=570;
		int padPrice=320;
		
		int shirtNo=2;
		int shoeNo=1;
		int padNo=1;
		
		double discount=0.8;
		
		System.out.println("�~�~�~�~�~�~�~*���ѵ�*�~�~�~�~�~�~�~");
		System.out.println("������Ʒ\t����\t����\t���");
		System.out.println("T��"+shirtNo+"\t��"+shirtPrice+"\t��"+(shirtNo*shirtPrice));
		System.out.println("����Ь"+shoeNo+"\t��"+shoePrice+"\t��"+(shoeNo*shoePrice));
		System.out.println("������"+padNo+"\t��"+padPrice+"\t��"+(padNo*padPrice));
		
		double totalPrice=(shirtNo*shirtPrice+shoeNo*shoePrice+padNo*padPrice)*discount;
		
		System.out.println("�ۿ�"+(int)(discount*10)+"��");
		Scanner input=new Scanner(System.in);
		System.out.println("�����ܽ���"+totalPrice);
		System.out.println("ʵ�ʽ��ѣ���");
		double money=input.nextInt();
		double diff=money-totalPrice;
		System.out.println("��Ǯ����"+diff);
		System.out.println("���ι���������֣�"+(int)(totalPrice/100*3));
	}
}
