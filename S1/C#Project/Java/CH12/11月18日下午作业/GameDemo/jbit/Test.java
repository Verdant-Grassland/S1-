package GameDemo.jbit;

public class Test {
	public static void main(String[] args) {
		Hero hero=new Hero();
		hero.name="��С��";
		hero.blood=300;
		Monster monster=new Monster();
		monster.name="С��";
		monster.blood=300;
		monster.type="Ǳˮ��";
		Weapon knife=new Weapon();
		knife.name="��������";
		knife.attckPower=12;
		hero.showInfo();
		knife.showInfo();
		monster.showInfo();
		
	}

}
