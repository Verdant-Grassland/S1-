package cn.jbit;

import java.util.Scanner;

public class TCosle {
	
	public static void main(String[] args) {
		Scanner input = new Scanner (System.in);
		System.out.println("���������ѽ��:");
		double money = input.nextInt();
		double extra = 0;
		int choice = 0;
		if(money>=50){
			System.out.println("�Ƿ�μ��Żݻ����:");
			System.out.println("1:��50Ԫ��2Ԫ�������¿�������1ƿ");
			System.out.println("2:��100Ԫ����3Ԫ����500ml����һƿ");
			System.out.println("3:��100Ԫ����10Ԫ����5�������");
			System.out.println("4:��200Ԫ����10Ԫ����1���ղ������˹�");
			System.out.println("5:��200Ԫ����20Ԫ����걲���ˬ��ˮһƿ");
			System.out.println("0:������");
			System.out.println("��ѡ��:");
			if(input.hasNextInt()==true){
				choice = input.nextInt();
				switch(choice){
				case 1:
					if(money>=50){
						extra = 2;
					}
					break;
				case 2:
					if(money>=100){
						extra = 3;
					}
					break;
				case 3:
					if(money>=100){
						extra = 10;
					}
					break;
				case 4:
					if(money>=200){
						extra = 10;
					}
					break;
				case 5:
					if(money>200){
						extra = 20;
					}
					break;
				default:
					break;
			}
		}else{
			System.out.println("��������ȷ�����֣�");
		}
	}

	double total = money + extra;
	System.out.println("���������ܽ��:"+ total);
	if(choice == 1){
		System.out.println("�ɹ�����:"+"���¿�������1ƿ��");
	}else if(choice ==2 ){
		System.out.println("�ɹ�����:"+"500ml����һƿ��");
	}else if(choice == 3){
		System.out.println("�ɹ�����:"+"5������ۡ�");
	}else if(choice == 4){
		System.out.println("�ɹ�����:"+"1���ղ������˹���");
	}else if(choice == 5){
		System.out.println("�ɹ�����:"+"ŷ����ˬ��ˮһƿ��");
	}else {
		System.out.println("�޻�����Ŀ��");
	}
	}
}
