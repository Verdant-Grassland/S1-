package cn.jbit;

public class Customer {
	int point;
	public String getType(){
		String CardVIP="";
		if(point >= 100 && point <= 1000){
			CardVIP = "�տ�";
		}else if(point >= 1001 && point <= 3000){
			CardVIP = "����";
		}else if(point >= 3001 && point <= 5000){
			CardVIP = "��";
		}
		return CardVIP;
	}
}
