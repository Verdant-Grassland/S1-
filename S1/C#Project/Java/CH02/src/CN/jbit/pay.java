package CN.jbit;

import java.util.Scanner;

public class pay {
	public static void main(String[] args){
		//定义
		int shirtPrice=245;
		int sgiePrice=570;
		int padPrice=320;
		
		int shirtNo=2;
		int shoeNo=1;
		int padNo=1;
		
		double discount=0.8;
		
		System.out.println("*****************消费单************");
		System.out.println("购买物品\t单价\t个数\t金额");
		System.out.println("T血\t"+shirtPrice+"\t￥"+shirtNo+"\t￥"+(shirtPrice*shirtNo));
		System.out.println("网球鞋\t"+sgiePrice+"\t￥"+shoeNo+"\t￥"+(sgiePrice*shoeNo));
		System.out.println("网球拍\t"+padPrice+"\t￥"+padNo+"\t￥"+(shirtPrice*padNo));
		//计算价格
		double zho=(shirtPrice*shirtNo+sgiePrice*shoeNo+padPrice*padNo)*discount;
		
		System.out.println("折扣"+(int)(discount*10)+"折");
		Scanner input=new Scanner(System.in);
		System.out.println("消费总金额是：￥"+zho);
		System.out.print("实际交费：￥");
		double money=input.nextDouble();
		double diff=money-zho;
		System.out.println("找钱：￥"+diff);
		System.out.println("本次购物获得的积分:"+(int)(zho/100*3));
		
		
		
		
		
		
		
		
		
	}
}
