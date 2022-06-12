package homework.jbit;

public class BuyCar {
	
	public static void main(String[] args) {
		int money =52;
		if(money>=500){
			System.out.println("太好了，我可以买凯迪拉克");
		}else if (money>=100){
			System.out.println("不错我可以买辆帕萨特");
		}else if (money>=50){
			System.out.println("我可以买个辆依兰特");
		}else if (money>=10){
			System.out.println("至少我可以奥托");
		}else {
			   System.out.println("看来，我只能买个捷安特了");
		}
	}
}
