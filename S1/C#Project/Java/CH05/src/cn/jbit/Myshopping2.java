package cn.jbit;

import java.util.Scanner;

public class Myshopping2 {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String answer = "y";	
		int shirtPrice = 245;
		int shoePrice = 570;
		int padPrice = 320;
		int shirtNo = 2;
		int shoeNo =1;
		int padNo = 1; 
		double total = 0;
		double money = 0;
		while(answer.equals("y")) {
			System.out.println("*******************************************");
			System.out.println("请选择购买的商品编号：");
			System.out.println("1.T恤        2.网球鞋        3.网球拍");
			System.out.println("*******************************************");
		
			System.out.println("请输入商品编号:");
			int num = input.nextInt();
			System.out.println("请输入商品数量:");
			int count = input.nextInt();
			switch(num){
			case 1:
				money = shirtPrice * count;
				System.out.println("T恤 \t￥"+shirtPrice+"\t数量"+count+"\t合计"+money);
				break;
			case 2:
				System.out.println("网球鞋\t￥"+padPrice+"\t数量"+count+"\t合计"+money);
				break;
			case 3:
				System.out.println("网球拍 \t￥"+padPrice+"\t数量"+count+"\t合计"+money);
				break;
			default:
				System.out.println("没有此菜单项");
				break;
			}
			total = total + money;
			System.out.println("是否继续(y/n)");
			answer = input.next();
		}
		System.out.println("折扣:0.3");
		total = total * 0.3;
		System.out.println("应付金额:"+total);
		System.out.println("实付金额:");
		int pay = input.nextInt();
		System.out.println("找零:"+(pay-total));
	}
}
