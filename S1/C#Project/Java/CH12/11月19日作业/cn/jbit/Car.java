package cn.jbit;

public class Car {
	String name;
	String color;
	public void show(){
		System.out.println("品牌名:" + name + "\n颜色:" + color);
	}
	public void Run(){
		System.out.println("汽车以20000/秒的速度行驶着");
	}
	public void stop(){
		System.out.println("汽车停止了");
	}
}
