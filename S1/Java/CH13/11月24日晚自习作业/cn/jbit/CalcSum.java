package cn.jbit;

public class CalcSum {
	public double calcAvg(int[] score) {
		int calcAvg = 0;
		for (int i = 0 ; i < score.length ; i++) {
			calcAvg = calcAvg + score[i];
		}
		return calcAvg;
	}
}
