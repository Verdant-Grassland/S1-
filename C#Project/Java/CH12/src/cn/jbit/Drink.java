package cn.jbit;

public class Drink {
	String DrinkName;
	public String getInfo(){
		String name = "";
		if(DrinkName.equals("ƻ��")){
			name = "���";
		}else if(DrinkName.equals("ɽ�")){
			name = "���";
		}else if(DrinkName.equals("����")){
			name = "���";
		}
		return name;
	}
}
