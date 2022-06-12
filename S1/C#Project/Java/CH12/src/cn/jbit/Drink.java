package cn.jbit;

public class Drink {
	String DrinkName;
	public String getInfo(){
		String name = "";
		if(DrinkName.equals("苹果")){
			name = "甜的";
		}else if(DrinkName.equals("山楂")){
			name = "酸的";
		}else if(DrinkName.equals("柠檬")){
			name = "苦的";
		}
		return name;
	}
}
