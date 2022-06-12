package 十一月十三日下午考试;

public class TestGame {

	/**
	 * 韩燕参加计算机变成大赛
	 * 如果获得第一名，将参加麻省理工大学组织胡1个月夏令营
	 * 如果获得第二名，将奖励惠普笔记本电脑一部
	 * 如果获得第三名，将奖励移动硬盘一个
	 * 否则，不给任何奖励
	 */
	public static void main(String[] args) {
		System.out.println("输入名次:");
		int mingci = 1;
		switch(mingci){
		case 1:
			System.out.println("参加麻省理工大学组织胡1个月夏令营");
			break;
		case 2:
			System.out.println("奖励hp笔记本电脑一部");
			break;
		case 3:
			System.out.println("奖励移动硬盘一部");
			break;
		default:
			System.out.println("没有任何奖励");
			break;
		}
	}
}
