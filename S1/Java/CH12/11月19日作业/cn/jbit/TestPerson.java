package cn.jbit;

public class TestPerson {

	public static void main(String[] args) {
		Person person = new Person();
		String name = person.sayHi();
		System.out.print("�����ҵ�������:" + name);
		int age = person.age();
		System.out.println("����" + age + "��");
		int larity = person.popularity();
		System.out.println("����ֵ" + larity);
	}
}
