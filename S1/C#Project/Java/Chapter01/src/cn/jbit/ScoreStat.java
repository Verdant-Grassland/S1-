package cn.jbit;
import java.util.Scanner;
public class ScoreStat {

	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("STB的成绩是：");
		int stb = input.nextInt();  
		int diffen;   
		double avg; 
		int java = 0;
		int sql = 5;
		diffen=java-sql;
		System.out.println("Java和SQL的成绩差"+diffen);
		avg=(stb+java+sql)/3;
		System.out.println("3门课的平均分是："+avg);
		
	}
}
