package cn.jbit;

public class Customer {
	int point;
	String cardType = "";
	public int points;
	public String show() {
		if(point >= 100 && point <= 1000){
			cardType = "?տ?";
		}else if(point >= 1001 && point <= 3000){
			cardType = "????";
		}else if(point >= 3001 && point <= 5000){
			cardType = "????";
		}
		return cardType;
	}
}
