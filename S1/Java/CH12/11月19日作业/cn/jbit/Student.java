package cn.jbit;

public class Student {
	int stuNo;
	String name;
	int age;
	String sex;
	String Schools = "";
	public void showInfo() {
		System.out.println("学号:" + stuNo + "姓名:" + name + "年龄:" + age + "性别" + sex);
	}
	public String getGrade(){
		if(age >= 7 && age <= 13){
			Schools = "小学";
		}else if(age >= 13 && age <= 16){
			Schools = "中学";
		}else if(age >= 16 && age <= 19){
			Schools = "中学";
		}else if(age >= 19 && age <= 23){
			Schools = "大学";
		}
		return Schools;
	}
}
