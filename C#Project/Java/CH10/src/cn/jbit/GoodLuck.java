package cn.jbit;

import java.util.Scanner;

public class GoodLuck {

	/**
	 * ���˳齱
	 */
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		String answer="y";
		while(answer.equals("y")){
			System.out.println("**********��ӭ���뽱�͸���ϵͳ*************************");
			System.out.println("\t\t1.ע��");
			System.out.println("\t\t2.��¼");
			System.out.println("\t\t3.�齱");
			System.out.println("***********************************************");
			System.out.println("��ѡ��˵�:");
			int choose=input.nextInt();
			//�û���
			String name="";
			//����
			String pwd="";
			//���ֵ
			int max=9999;
			//��Сֵ
			int min=1000;
			//�������λ��Ա����
			int cardNo=(int)(Math.random()*(max-min))+min;
			//�Ƿ�ע��ɹ��ı�ʶλ
			boolean isReg=false;
			switch(choose){
			case 1:
				System.out.println("[���͸���ϵͳ>ע��]");
				System.out.println("�������û�����");
				name=input.next();
				System.out.println("���������룺");
				pwd=input.next();
				
				System.out.println("\nע��ɹ�����Ǻû�Ա����");
				System.out.println("�û���\t����\t��Ա����");
				System.out.println(name+"\t"+pwd+"\t"+cardNo);
				//isRegΪtrue��ʾע��ɹ���falseע��ʧ��
				isReg=true;
				break;
			case 2:
				System.out.println("[���͸���ϵͳ>��¼]");
				if(isReg){
					
				}else{
					System.out.println("����û��ע���أ����ܵ�¼");
				}
				break;
			case 3:
				System.out.println("[���͸���ϵͳ>�齱]");
				break;
			default:
				System.out.println("û�д�ѡ��");
				break;
			}
			System.out.print("������(y/n)");
			answer=input.next();
		}
		System.out.println("�˳�ϵͳ��ллʹ��");
		
	}

}
