package GameDemo.jbit;

public class Test {
	public static void main(String[] args) {
		Hero hero=new Hero();
		hero.name="李小侠";
		hero.blood=300;
		Monster monster=new Monster();
		monster.name="小龟";
		monster.blood=300;
		monster.type="潜水类";
		Weapon knife=new Weapon();
		knife.name="死神镰刀";
		knife.attckPower=12;
		hero.showInfo();
		knife.showInfo();
		monster.showInfo();
		
	}

}
