package cn.jbit;

import java.util.Scanner;

public class Menu {
	Scanner input = new Scanner(System.in);
	public void showLoginMenu(){
		System.out.println("\n\t欢迎使用我行我素购物管理系统\n");
		System.out.println("\t\t 1. 登 录 系 统\n");
		System.out.println("\t\t 2. 退 出\n");
		System.out.println ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
		System.out.print("请选择,输入数字:");
	}
	public void showMainMenu(){
	  	System.out.println("\n\t我行我素购物管理系统主菜单\n");
	 	System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
	 	System.out.println("\t\t 1. 客 户 信 息 管 理\n"); 		
	 	System.out.println("\t\t 2. 真 情 回 馈\n"); 		
	 	System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
	 	System.out.print("请选择,输入数字或按0返回上一级菜单:"); 		
	 	int num = input.nextInt();
	 	boolean flag;
	 	do{
	 		flag = false;
	 		switch(num) {
	 		case 1:
	 			ShowCustMenu();
	 			break;
	 		case 2:
	 			showLoginMenu();
	 			break;
	 		case 0:
	 			showLoginMenu();
	 			break;
	 		default:
	 			System.out.println("菜单选择错误，请重新输入:");
	 			num = input.nextInt();
	 			flag = true;
	 			break;
	 		}
	 	}while(flag);
	}
	
	public void ShowCustMenu(){
	 	System.out.println("\n\t我行我素购物管理系统 > 客户信息管理");
	 	System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
	 	System.out.println("\t\t  1. 显 示 所 有 客 户 信 息\n");
	 	System.out.println("\t\t  2. 添 加 客 户 信 息\n");
	 	System.out.println("\t\t  3. 修 改 客 户 信 息\n");
	 	System.out.println("\t\t  4. 查 询 客 户 信 息\n");
	 	System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
	 	System.out.print("请选择,输入数字或按0返回上一级菜单:");
	 	int num = input.nextInt();
	 	boolean flag;
	 	do{
	 		flag = false;
	 		switch(num) {
	 		case 1:
	 			System.out.println("执行显 示 所 有 客 户 信 息");
	 			break;
	 		case 2:
	 			System.out.println("执行添 加 客 户 信 息");
	 			break;
	 		case 3:
	 			System.out.println("执行修 改 客 户 信 息");
	 			break;
	 		case 4:
	 			System.out.println("执行 查 询 客 户 信 息");
	 			break;
	 		case 0:
	 			showMainMenu();
	 			break;
	 		default:
	 			System.out.println("菜单选择错误，请重新输入:");
	 			num = input.nextInt();
	 			flag = true;
	 			break;
	 		}
	 	}while(flag);
	}
	
	public void showSendGMenu(){
		 System.out.println("\n\t我行我素购物管理系统 > 真情回馈");
		 System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
		 System.out.println("\t\t 1. 幸 运 大 放 送\n");
		 System.out.println("\t\t 2. 幸 运 抽 奖\n");
		 System.out.println("\t\t 3. 生 日 问 候\n");
		 System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
		 System.out.print("请选择,输入数字或按0返回上一级菜单：");
		 int num = input.nextInt();
		 boolean flag;
		 do{
			 flag = false;
			 switch(num){
			 case 1:
		 		System.out.println("执行幸 运 大 放 送");
		 		break;
		 	case 2:
		 		System.out.println("执行幸 运 抽 奖");
		 		break;
		 	case 3:
		 		System.out.println("执行生 日 问 候");
		 		break;
		 	case 0:
		 		showMainMenu();
		 		break;
		 	default:
		 		System.out.println("菜单选择错误，请重新输入:");
		 		num = input.nextInt();
		 		flag = true;
		 		break;
		 	}
		}while(flag);	
	}
}

