package cn.jbit;

public class Student01 {
	public String result(String word){
		String result = "学习";
		if(word.equals(result)){
			System.out.println("学习:选择更多的机会，不是被迫谋生");
		}else{
			System.out.println("不学习:一辈子要吃生活的苦");
		}
		return result;
	}
}
