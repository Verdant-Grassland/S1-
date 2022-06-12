package GameDemo.jbit;

public class Weapon {
	public String name;
	public int attckPower;
	public void showInfo(){
		System.out.println("我是武器，我的基本信息如下：");
		System.out.println("武器名："+name+",攻击力："+attckPower);
	}
}
