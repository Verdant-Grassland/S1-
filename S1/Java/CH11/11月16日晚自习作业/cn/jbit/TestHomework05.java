package cn.jbit;

public class TestHomework05 {
	
	/**
	 * 回馈积分
	 */

	public static void main(String[] args) {
		Customer cust = new Customer();
		cust.points = 3050;
		cust.cardType = "金卡";
		cust.show();
		if((cust.points > 1000 && cust.cardType.equals("金卡")) || (cust.points>5000 && cust.cardType.equals("普卡"))){
			System.out.println("回馈积分500分！");
		}
	}
}
