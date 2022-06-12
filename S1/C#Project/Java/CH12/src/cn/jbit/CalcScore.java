package cn.jbit;

public class CalcScore {
	int Java;
	int C;
	int DB;
	public int calcSum(){
		int sum = Java + C + DB;
		return sum;
	}
	public double calcAvg(){
		int sum = calcSum();
		double avg = sum/3;
		return avg;
	}
	public void showSum(){
		System.out.println("总分是:" + calcSum());
	}
	public void showAvg(){
		double avg = calcAvg();
		System.out.println("平均分是:" + avg);
	}
}
