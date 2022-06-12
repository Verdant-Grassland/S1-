package GameDemo.jbit;

public class Monster {

	public String name;
	public int blood;
	public String type;
	public void showInfo(){
		System.out.println("我是怪物，我的基本信息如下：");
		System.out.println("姓名:"+name+",生命值:"+blood+",类型："+type);
	}
}
