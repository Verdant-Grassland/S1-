using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrorageManage
{
    /// <summary>
    /// 商品类
    /// </summary>
    class Goods
    {
        //满意度
        private int goodPleased;

        public int GoodPleased
        {
            get { return goodPleased; }
            set { goodPleased = value; }
        }

        //价格
        private int goodPrice;

        public int GoodPrice
        {
            get { return goodPrice; }
            set { goodPrice = value; }
        }
        
        //商品名字
        private string goodsName;

        public string GoodsName
        {
            get { return goodsName; }
            set { goodsName = value; }
        }

        //位置
        private string goodsPlace;

        public string GoodsPlace
        {
            get { return goodsPlace; }
            set { goodsPlace = value; }
        }
    }

    /// <summary>
    /// 货品类
    /// </summary>
    class Storage
    {
        //对象数组
        Goods[] goods = new Goods[3];
        #region 初始化货品信息
        public void Initial()
        {
            Goods good1 = new Goods();
            good1.GoodPleased = 100;
            good1.GoodPrice = 10;
            good1.GoodsName = "杯子";
            good1.GoodsPlace = "第一仓库第一排";

            Goods good2 = new Goods();
            good2.GoodPleased = 96;
            good2.GoodPrice = 25;
            good2.GoodsName = "花瓶";
            good2.GoodsPlace = "第一仓库第二排";

            Goods good3 = new Goods();
            good3.GoodPleased = 98;
            good3.GoodPrice = 10;
            good3.GoodsName = "热水器";
            good3.GoodsPlace = "第一仓库第三排";

            //将对象存到数组中
            goods[0] = good1;
            goods[1] = good2;
            goods[2] = good3;
        }
        #endregion

        #region 显示基本信息
        public void ShowGoods()
        {
            Console.WriteLine("库存货品清单列表");
            Console.WriteLine("-------------------------------");
            //遍历对象数组
            foreach (Goods item in goods)
            {
                Console.WriteLine("货品名称是：" + item.GoodsName);
            }
            Console.WriteLine("-------------------------------");
        }
        #endregion

        #region 显示菜单
        public void ShowMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("\n=====================欢迎使用库存管理系统====================");
                Console.WriteLine(" 1:根据货品名称获取货品位置 2:取得客户满意度最高的货品 3:退出");
                Console.WriteLine("=============================================================");
                Console.WriteLine("请选择：");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("请输入商品：");
                        string name = Console.ReadLine();
                        string place = GetGoodPlace(name);
                        if (place == null)
                        {
                            Console.WriteLine("没有此商品");
                        }
                        else
                        {
                            Console.WriteLine(place);
                        }
                        break;
                    case 2:
                        GetMaxPleased();
                        break;
                    case 3:
                        flag = false;
                        Console.WriteLine("退出系统，谢谢使用！");
                        break;
                    default:
                        break;
                }
            } while (flag);
        }
        #endregion

        #region 根据货品名称获取货品位置
        public string GetGoodPlace(string name)
        {
            //循环对象数组
            foreach (Goods good in goods)
            {
                //找到商品
                if (good.GoodsName == name)
                {
                    //返回商品位置
                    return good.GoodsPlace;
                }
            }
            return null;
        }
        #endregion

        #region 返回客户满意度最高的货品
        public void GetMaxPleased()
        {
            Goods good = new Goods();
            foreach (Goods item in goods)
            {
                //如果good对象的满意度小于对象数组中的满意度
                if (good.GoodPleased < item.GoodPleased)
                {
                    good = item;
                }
            }
            Console.WriteLine("温馨提示：");
            Console.WriteLine("客户满意度最高的货品是：{0}，摆放在：{1}，满意度是：{2}，价格是：{3}", good.GoodsName, good.GoodsPlace, good.GoodPleased, good.GoodPrice);
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage();
            storage.Initial();
            storage.ShowGoods();
            storage.ShowMenu();
            Console.ReadLine();
        }
    }
}
