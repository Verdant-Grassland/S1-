package CN.jbit;

import java.util.Scanner;

public class hui {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("����4λ�Ļ�Ա����");
		Scanner input=new Scanner(System.in);
		int hao=input.nextInt();
		if(hao<10000&&hao>1000){
			System.out.println("�����Ա���գ�");
			String sen=input.next();
			System.out.println("���������");
			int fen=input.nextInt();
			System.out.println("\n��¼���Ա��Ϣ�ǣ�");
			System.out.println(hao+"\t"+sen+"\t"+fen);
		}else{
			System.out.println("��Ա���Ŵ���������4λ�Ŀ���");
			
		}
	}

}
