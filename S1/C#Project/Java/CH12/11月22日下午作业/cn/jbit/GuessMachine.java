package cn.jbit;

import java.util.Scanner;

public class GuessMachine {
	String name ;
	   double price;
	    public void initial(){
	        int random = (int)(Math.random()*10);
	        switch(random){
	          case 0:
	          case 1:
	          case 2:
	          case 3: 
	        	  name = "�����綯��";
	        	  price = 2000;
	        	  break;
	          case 4:
	          case 5:
	          case 6: 
	        	  name = "34�紿ƽ�ʵ�";
	        	  price = 3000;
	        	  break;
	          case 7:
	          case 8:
	          case 9:
	        	  name = "�·ɱ���";
	        	  price = 3400;
	        	  break;
	          default: 
	        	  break;
	        }  
	    }   
	    
	    public void Guess(){
	    	System.out.print("��²�\""+ name + "\"�ļ۸�:" );
	    	Scanner input = new Scanner(System.in);
	    	double GuessPrice = input.nextDouble();
	    	boolean isCorrect = false;
	    	for(int i = 0; i<3; i++){		
	    		if(GuessPrice == price){
	    			System.out.println("�¶��ˣ�");
	    			isCorrect = true;
	    			break;
	    		}else if(GuessPrice > price){
	    			System.out.println("��С�㣡");
	    		}else{
	    			System.out.println("�ٴ�㣡");
	    		}
	    		System.out.print("\n�ٲ�һ�ΰ�: ");
	    		GuessPrice = input.nextDouble(); 
	    	}
	    	if(!isCorrect){
	    		System.out.println("\n4����û�в¶ԣ��´�Ŭ���ɣ�");
	    	}
	    }
	}
