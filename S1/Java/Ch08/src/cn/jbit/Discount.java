package cn.jbit;

public class Discount {

	public static void main(String[] args) {
		System.out.println("本次活动特价商品有:");
		String []shopping = new String[]{"Nike背包","Adidas运动衫","李宁运动鞋","Kappa外套","361°腰包"};
		for(int i = 0 ; i<shopping.length ; i++){
			System.out.println(shopping[i]);
		}
	}
}
