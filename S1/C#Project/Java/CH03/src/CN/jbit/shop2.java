package cn.jbit;
                                                                               
import java.util.Scanner;                                                      																				
																				
public class shop2 {                                                           
	                                                                                 
	public static void main(String[] args) {                                         
		System.out.println("�������Ա���֣�");                                  
		Scanner input=new Scanner(System.in);                                        
		int custScore=input.nextInt();                                               
		double discount;                                                             
		                                                                             
		if (custScore<2000){                                                         
			discount=0.9;                                                            
		}else if(2000<=custScore&&custScore<4000){                                   
			discount=0.8;                                                            
		}else if(4000<=custScore&&custScore<8000){                                   
			discount=0.7;                                                            
		}else{                                                                       
			discount=0.6;                                                            
		}                                                                            
		System.out.println("�û�Ա���ܵ��ۿ��ǣ�" + discount);                            
	}                                                                                
}                                                                                     