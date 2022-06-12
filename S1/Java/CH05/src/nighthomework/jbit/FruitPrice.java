package nighthomework.jbit;

import java.util.Scanner;

public class FruitPrice {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int i=1;
double sum=0;
while(i<=4){
	System.out.println("请输入第"+i+"种水果的价格：")
	int price=input.nextInt();
	sum=sum+price;
	i++;
			}
double avg=sum/4;
		}
	}
}
