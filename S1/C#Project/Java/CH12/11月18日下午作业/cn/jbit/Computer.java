package cn.jbit;

public class Computer {
	String CPU = "";
	String main_board = "";
	String monitor = "";
	String hard_disk = "";
	String memory = "";
	public void showInfo(){
		System.out.println("计算机配置如下：\nCPU:" + CPU + ";\n主板:" + main_board + ";\n内存:" + memory + ";\n硬盘:" + hard_disk + ";\n显示器:" + monitor);
	}
}
