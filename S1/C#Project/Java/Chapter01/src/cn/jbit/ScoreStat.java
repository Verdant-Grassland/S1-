package cn.jbit;
import java.util.Scanner;
public class ScoreStat {

	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("STB�ĳɼ��ǣ�");
		int stb = input.nextInt();  
		int diffen;   
		double avg; 
		int java = 0;
		int sql = 5;
		diffen=java-sql;
		System.out.println("Java��SQL�ĳɼ���"+diffen);
		avg=(stb+java+sql)/3;
		System.out.println("3�ſε�ƽ�����ǣ�"+avg);
		
	}
}