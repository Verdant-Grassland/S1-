package cn.jbit;

public class Shape {
	int row;
	String design;
	public void printDesign(){
		for(int i=1;i<=row;i++){
			for(int k=1;k<=i;k++){
				System.out.print(design);
			}
			System.out.println();
		}
	}
}