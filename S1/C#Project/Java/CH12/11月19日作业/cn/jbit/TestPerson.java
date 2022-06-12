package cn.jbit;

public class TestPerson {

	public static void main(String[] args) {
		Person person = new Person();
		String name = person.sayHi();
		System.out.print("您好我的名字是:" + name);
		int age = person.age();
		System.out.println("年龄" + age + "岁");
		int larity = person.popularity();
		System.out.println("人气值" + larity);
	}
}
