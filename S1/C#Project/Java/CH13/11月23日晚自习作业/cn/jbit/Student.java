package cn.jbit;

public class Student {
	int score;
	String grade;
	public String getGrade(int score){
		if(score >= 85 && score <= 100){
			grade = "A";
		}else if(score >= 70 && score <= 84){
			grade = "B";
		}else if(score >= 60 && score <= 69){
			grade = "C";
		}else{
			grade = "D";
		}
		return grade;
	}
}
