package cn.jbit;

public class MyTime {
	double times;
	public String getInfo(){
		String time = "";
		if(times >= 5 && times <= 10){
			time = "?糿";
		}else if(times >= 11 && times <= 13){
			time = "????";
		}else if(times >= 13 && times <= 19){
			time = "????";
		}else if(times >= 18 && times <= 24){
			time = "????";
		}else{
			time = "?峿";
		}
		return time;
	}
}
