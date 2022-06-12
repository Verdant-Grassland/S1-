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
		
		System.out.println("﹡﹡﹡﹡﹡﹡﹡*消费单*﹡﹡﹡﹡﹡﹡﹡");
		System.out.println("购买物品\t个数\t单价\t金额");
		System.out.println("T恤"+shirtNo+"\t￥"+shirtPrice+"\t￥"+(shirtNo*shirtPrice));
		System.out.println("网球鞋"+shoeNo+"\t￥"+shoePrice+"\t￥"+(shoeNo*shoePrice));
		System.out.println("网球拍"+padNo+"\t￥"+padPrice+"\t￥"+(padNo*padPrice));
		
		double totalPrice=(shirtNo*shirtPrice+shoeNo*shoePrice+padNo*padPrice)*discount;
		
		System.out.println("折扣"+(int)(discount*10)+"折");
		Scanner input=new Scanner(System.in);
		System.out.println("消费总金额：￥"+totalPrice);
		System.out.println("实际交费：￥");
		double money=input.nextInt();
		double diff=money-totalPrice;
		System.out.println("找钱：￥"+diff);
		System.out.println("本次购物所获积分："+(int)(totalPrice/100*3));
	}
}
