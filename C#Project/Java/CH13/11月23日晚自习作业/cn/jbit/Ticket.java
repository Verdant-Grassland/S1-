package cn.jbit;

public class Ticket {
	public String sale(int money){
	String ticket ="";
	if(money >= 20 && money <= 60){
		ticket = "Ӳ��Ʊ";
	}else if(money >= 120 && money <= 200){
		ticket = "����Ʊ";
	}else if(money >= 240 && money <= 300){
		ticket = "����Ʊ";
	}
	return ticket;
	}
}
