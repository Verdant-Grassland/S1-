package GameDemo.jbit;

public class Hero {
	public String name;
	public int blood;
	public void showInfo(){
		System.out.println("我是英雄，我的基本信息如下：");
		System.out.println("姓名:"+name+",生命值:"+blood);
	}
}
