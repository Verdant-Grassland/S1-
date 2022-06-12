package CN.jbit;

import java.util.Scanner;

public class hui {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("输入4位的会员卡号");
		Scanner input=new Scanner(System.in);
		int hao=input.nextInt();
		if(hao<10000&&hao>1000){
			System.out.println("输入会员生日：");
			String sen=input.next();
			System.out.println("请输入积分");
			int fen=input.nextInt();
			System.out.println("\n已录入会员信息是：");
			System.out.println(hao+"\t"+sen+"\t"+fen);
		}else{
			System.out.println("会员卡号错误请输入4位的卡号");
			
		}
	}

}
