package cn.jbit;

public class Student {
	int stuNo;
	String name;
	int age;
	String sex;
	String Schools = "";
	public void showInfo() {
		System.out.println("ѧ��:" + stuNo + "����:" + name + "����:" + age + "�Ա�" + sex);
	}
	public String getGrade(){
		if(age >= 7 && age <= 13){
			Schools = "Сѧ";
		}else if(age >= 13 && age <= 16){
			Schools = "��ѧ";
		}else if(age >= 16 && age <= 19){
			Schools = "��ѧ";
		}else if(age >= 19 && age <= 23){
			Schools = "��ѧ";
		}
		return Schools;
	}
}
