package cn.jbit;

import java.util.Scanner;

public class console2 {

	public static void main(String[] args){
		int liSi = 80;          //学员李四成绩
		boolean isBig ;           
		Scanner input = new Scanner(System.in);   
		System.out.print("输入学员张三成绩: ");       
		int zhangSan =  input.nextInt();                     //输入张三的成绩      
		isBig = zhangSan > liSi ; 
		boolean isSmall = zhangSan <liSi ; 
		System.out.println( "张三成绩比李四高吗 ？ "+isBig );    //输出比较结果

	}

}
