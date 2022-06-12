package cn.jbit;

public class TestInter {

	public static void main(String[] args) {
		int[] a=new int[]{3,4,5,6,7};
		int[] b=new int[]{1,2,3,4,5,0,0,0};
		b[5] = a[0] * b[2];
		b[6] = a[1] * b[3];
		b[7] = a[2] * b[4];
		for(int i = 0 ; i<b.length ; i++){
			System.out.println(b[i]);
		}
	}
}
