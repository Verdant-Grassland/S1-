package CN.jbit;

import java.util.Scanner;

public class pay {
	public static void main(String[] args){
		//����
		int shirtPrice=245;
		int sgiePrice=570;
		int padPrice=320;
		
		int shirtNo=2;
		int shoeNo=1;
		int padNo=1;
		
		double discount=0.8;
		
		System.out.println("*****************���ѵ�************");
		System.out.println("������Ʒ\t����\t����\t���");
		System.out.println("TѪ\t"+shirtPrice+"\t��"+shirtNo+"\t��"+(shirtPrice*shirtNo));
		System.out.println("����Ь\t"+sgiePrice+"\t��"+shoeNo+"\t��"+(sgiePrice*shoeNo));
		System.out.println("������\t"+padPrice+"\t��"+padNo+"\t��"+(shirtPrice*padNo));
		//����۸�
		double zho=(shirtPrice*shirtNo+sgiePrice*shoeNo+padPrice*padNo)*discount;
		
		System.out.println("�ۿ�"+(int)(discount*10)+"��");
		Scanner input=new Scanner(System.in);
		System.out.println("�����ܽ���ǣ���"+zho);
		System.out.print("ʵ�ʽ��ѣ���");
		double money=input.nextDouble();
		double diff=money-zho;
		System.out.println("��Ǯ����"+diff);
		System.out.println("���ι����õĻ���:"+(int)(zho/100*3));
		
		
		
		
		
		
		
		
		
	}
}