package cn.jbit;

import java.util.Scanner;

public class TestBuySprice {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int count = 0;
		double price = 0.0;
		for(int i = 0 ; i < 3 ; i++){
			System.out.println("请输入第" + (i + 1) + "个人所购的三件商品的价格:");
			for(int j = 0 ; j < 3 ; j++){
				price = input.nextInt();
				if(price < 300)
					continue;
				count++;
			}
			System.out.println("第" + (i+1) + "共有" + count + "商品享受8折优惠！");
			count = 0;
		}
	}
}
