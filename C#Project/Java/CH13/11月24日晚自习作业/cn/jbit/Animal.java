package cn.jbit;

public class Animal {
	public String show (String cry){
		String show = "";
		if(cry.equals("¹·")){
			show = "ÍôÍô";
		}else if(cry.equals("Öí")){
			show = "ºôàà";
		}else if(cry.equals("Ã¨")){
			show = "ß÷ß÷";
		}
		return show;
	}
}
