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
	        	  name = "公主电动车";
	        	  price = 2000;
	        	  break;
	          case 4:
	          case 5:
	          case 6: 
	        	  name = "34寸纯平彩电";
	        	  price = 3000;
	        	  break;
	          case 7:
	          case 8:
	          case 9:
	        	  name = "新飞冰箱";
	        	  price = 3400;
	        	  break;
	          default: 
	        	  break;
	        }  
	    }   
	    
	    public void Guess(){
	    	System.out.print("请猜测\""+ name + "\"的价格:" );
	    	Scanner input = new Scanner(System.in);
	    	double GuessPrice = input.nextDouble();
	    	boolean isCorrect = false;
	    	for(int i = 0; i<3; i++){		
	    		if(GuessPrice == price){
	    			System.out.println("猜对了！");
	    			isCorrect = true;
	    			break;
	    		}else if(GuessPrice > price){
	    			System.out.println("再小点！");
	    		}else{
	    			System.out.println("再大点！");
	    		}
	    		System.out.print("\n再猜一次吧: ");
	    		GuessPrice = input.nextDouble(); 
	    	}
	    	if(!isCorrect){
	    		System.out.println("\n4次内没有猜对，下次努力吧！");
	    	}
	    }
	}
