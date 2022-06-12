## 属性设计

#### 窗体的属性：

##### 1.Text:窗体的标题栏显示的文字

##### 2.StartPosition:CenterScreen   窗体启动时居中显示

##### 3.icon:设置窗体的图标

##### 4.MaximizeBox:False  禁用最大化

##### 5.MinimizeBox:False 禁用最小化

##### 6.FormBorderStyle:FixedSingle  窗体启动时不能拉拽窗体边缘

##### 7.BackgroundImage:设置背景图象

##### 8.BackgroundImageLayout:Stretch  让背景图象去适应窗体的大小

##### 9.isMdiContainer:true   设置为mdi窗体

#### Label控件设计属性

##### 1.Text:Label控件显示的文本

##### 2.Name:名称   命名规范：lbl ...    例如：lblName

##### 3.BackColor:Transparent   (web---Transparent)  背景色：透明

##### 4.Font:设计字体、字形、字号

##### 密码的Label的名称叫:lblPwd    登录类型Label名称叫lblType

#### 复制控件：ctrl拖动控件

#### TextBox文本框

##### 1.Name：名称   命名规范：txt....    例如：txtName

##### 2.BorderStyle:FixedSingle   边框：细线

##### 3.PasswordChar:*     输入密码显示的字符

##### 4.ReadOnly:true   只读

#### ComboBox:下拉列表

##### 1.Name：名称   命名规范 cbo...或是cmb...  例如：cboType

##### 2.DropDownStyle:DropDownList    组合框外观功能

##### 3.Items：组合框中的项   例如：管理员  学生

#### button:按钮

##### 1.Name:名字   命名规范:btn....   例如：btnLogin    btnCancle

##### 2.BackgroundImage:背景图象

##### 3.FlatAppearance---->BorderSize:0   边框粗细：无

#####    FlatStyle:Flat   控件外观   Flat边框

##### 5.Text:按钮上的文本

##### 6.Size:按钮大小    width:84   height:22

#### MenuStrip:菜单栏

##### 1.name:名称    命名规范tsmi.....  例如：tsmiAddStudent

#### ToolStrip:工具栏

##### 1.name:名称   命名规范tsbtn....    例如：tsbtnSearch

##### 2.DisplayStyle:ImageAndText (图象和文本一起显示)            是否呈现图象和文本  

##### 3.Image:图象

##### 4.ImageScaling:None    是否控制图象的大小：不控制

##### 5.Text:在项上显示的文本

##### 6.TextImageRelation:ImageBeforeText    图象和文本的关系      ImageBeforeText表示图象在前，文本在后

#### GroupBox:组

##### 1.name:名字      规范：gb...    例如：gbInfo

##### 2.Text:文本

#### RadioButton:单选按钮

##### 1.name:名字    规范：rbtn....   例如：rbtnSex

##### 2.Text:文本

##### 3.Checked:true   选中     true为选中,false不选中

#### DateTimePicker:日期控件

##### 1.name：名字   规范：dtp....   例如：dtpBirthday

#### PictureBox:

##### 1.name:名字      规范：pb...    例如：pbShow

##### 2.sizeMode:auto    图象和控件大小的关系.auto是让控制去适应图象的大小   

## 非空验证

#### 1.第一种方法

```javascript
//遍历所有的控件
foreach (Control item in Controls)
{
       //如果是文本框
        if (item is TextBox)
        {
            //文本框非空验证
              if (item.Text=="")
              {
                       MessageBox.Show("所有文本框均不能为空");
                        //返回窗体
              }        return;
       }
 }
```

#### 2.第二种方法

```c#
if (txtName.Text=="" || txtNote.Text=="" || txtPerson.Text=="" || txtReason.Text=="" || txtTime.Text=="")
{
                MessageBox.Show("所有文本框均不能为空 ");
                return;
 }
```

#### 3.第三种方法

```c#
public bool Check()
{
            if (txtTime.Text=="")
            {
                MessageBox.Show("时间不能为空");
                return false;
            }
            else if (txtName.Text=="")
            {
                MessageBox.Show("会议室名称不能为空");
                return  false;
            }
            else if (txtReason.Text=="")
            {
                MessageBox.Show("原因不能为空");
                return false;
            }
            else if (txtPerson.Text=="")
            {
                MessageBox.Show("预订人员不能为空");
                return false;
            }
            else if (txtNote.Text=="")
            {
                 MessageBox.Show("录入人员不能为空");
                return false;
            }
            else
            {
                return true;
            }
            
 }
```

##### 第三种方法的调用：

在添加/提交按钮里调用：

```c#
if(Check())
{
	//添加功能

}
```

## 添加功能

##### 案例：

```c#
//添加功能
string sql="insert into 表名(字段名1，字段名2，字段名3) values(值1,值2,值3)";
//调用增删改方法
int result = DBHelper.DoNonQuery(sql);
if (result > 0)
{
        MessageBox.Show("添加成功");
}
else
{
        MessageBox.Show("添加失败");
}
```

## 清空

#### 1.第一种方法

```c#
txtName.Text = "";      txtName是文本框名称
```

#### 2.第二种方法

```c#
foreach (Control item in Controls)
{
                //如果是文本框控件
                if (item is TextBox)
                {
                    //文本框清空
                    item.Text = "";
                }
 }
```

## 取消录入

```c#
 //弹出提示的消息框
 DialogResult result = MessageBox.Show("确定要取消吗？","提示信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
//如果点击对话框中的确定
if (result==DialogResult.OK)
{
          //关闭窗体
          this.Close();
}
 else
{
         MessageBox.Show("你取消了操作");
}
```

## 点击菜单显示窗体

```c#
//创建新增窗体的对象
FrmAddStudent frmStudent = new FrmAddStudent();
//设置父窗体
frmStudent.MdiParent = this;
//显示窗体
frmStudent.Show();
```

## 退出整个应用程序

```javascript
//退出整个应用程序
Application.Exit();
```

## 窗体启动时显示年级

```c#
private void FrmAddStudent_Load(object sender, EventArgs e)
{
			 string sql = "select * from grade";
            //调用通用方法
            SqlDataReader reader = DBHelper.DoReader(sql);
            cboGrade.Items.Add("请选择");
            //第1个选项选中
            cboGrade.SelectedIndex = 0;
            while (reader.Read())
            {
                //下接列表框选项添加
                cboGrade.Items.Add(reader["gradeName"].ToString());
            }
            reader.Close();
}
 Load事件是窗体启动时加载事件
```

## Anchor锚定控件的边缘

##### 应用：将控件的Anchor属性值设置为left、top、right、bottom，这样控件会随着窗体的大小变化而变化

## Dock属性

##### Dock属性的作用：控件停靠到窗体的上，下，左右四个边缘

##### Dock:fill 表示控件填满整个窗体

## ImageList控件

##### 1.Name:控件名称

##### 2.ColorDepth:Depth32Bit

##### 3.ImageSize:图象大小，按照图象的实际大小设计

##### 4.Images:图象集合

## ListView控件

##### 1.name:控件名称

##### 2.items：项的集合

##### 3.columns:列的设置

##### 4.LargeImageList:绑定大图标的ImageList控件

##### 5.SmallImageList:绑定小图标的ImageList控件

##### 6.View：视图

##### 1)LargeIcon:大图标

##### 2)SmallIcon:小图标

##### 3)Details:详细列表

##### 4)List:列表

##### 5)Title:标题

##### 7.FullRowSelect：true  单击某个项，将整行选中

##### 8.ContextMenuStrip:选择右键菜单的控件名 (绑定右键菜单)

## ContextMenuStrip:右键菜单

##### 1.name：名字   命名规范：tsmi.....    例如：tsmiAdd

##### 案例：QQ列表

```C#
private void Form1_Load(object sender, EventArgs e)
 {
            //建立项
            ListViewItem itemA = new ListViewItem("小强");
            //项的图象编号
            itemA.ImageIndex = 0;
            //添加子项
            itemA.SubItems.Add("12364551");
            itemA.SubItems.Add("男");
            itemA.SubItems.Add("18");


            //建立项
            ListViewItem itemB = new ListViewItem("小云");
            itemB.ImageIndex = 1;
            //添加子项
            itemB.SubItems.Add("78965456");
            itemB.SubItems.Add("女");
            itemB.SubItems.Add("19");

            //建立项
            ListViewItem itemC = new ListViewItem("小刚");
            itemC.ImageIndex = 2;
            //添加子项
            itemC.SubItems.Add("12356989");
            itemC.SubItems.Add("男");
            itemC.SubItems.Add("20");

            //将项加入到ListView控件
            this.lvShow.Items.Add(itemA);
            this.lvShow.Items.Add(itemB);
            this.lvShow.Items.Add(itemC);
  }
```

## 点击学生用户管理----按姓名查询弹出窗体

```c#
FrmSearch frmSearch = new FrmSearch();
frmSearch.MdiParent = this;
frmSearch.Show();
```

## 实现按姓名查询学生信息

```c#
public void SearchInfo()
{
            //清除所有数据
            if (this.lvShow.Items.Count>0)
            {
                //清除所有的项，即清除所有的行
                this.lvShow.Items.Clear();
            }
            string sql = @"select s.StudentNo,s.StudentName,s.Gender,g.GradeName
                        from Student s  inner join Grade g on s.GradeId=g.GradeId where 1=1";
            if (txtName.Text!="")
            {
                sql += "   and s.StudentName like '%"+txtName.Text+"%'";
            }
            SqlDataReader reader = DBHelper.DoReader(sql);
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["StudentNo"].ToString());
                //添加子项
                item.SubItems.Add(reader["StudentName"].ToString());
                item.SubItems.Add(reader["Gender"].ToString());
                item.SubItems.Add(reader["GradeName"].ToString());
                //将项添加到ListView控件
                lvShow.Items.Add(item);
            }
            reader.Close();

 }
```

##### 窗体启动时调用方法：

```c#
private void FrmSearch_Load(object sender, EventArgs e)
{
            SearchInfo();
 }
```

##### 点击按钮调用方法：

```c#
 private void btnSearch_Click(object sender, EventArgs e)
 {
           SearchInfo();
 }
```

##### 退出整个应用程序

```c#
Application.Exit();
```

## 社团管理的关键代码

#### 1.非空验证和添加

```c#
private void btnSubmit_Click(object sender, EventArgs e)
        {
            //遍历所有的控件
            foreach (Control item in Controls)
            {
                //判断控件是否是文本框
                if (item is TextBox)
                {
                    //文本框为空
                    if (item.Text=="")
                    {
                        MessageBox.Show("所有文本框均不能为空");
                        return;
                    }
                }
            }
            //添加功能
            string sql = string.Format(@"insert into Organizations(name,description,principal,telephone,registrationDate) 
                        values('{0}','{1}','{2}','{3}','{4}')",txtName.Text,txtContent.Text,txtPerson.Text,txtPhone.Text,txtDate.Text);
            //调用增删改方法
            int result = DBHelper.DoNonQuery(sql);
            if (result>0)
            {
                MessageBox.Show("添加成功");
                ClearData();    //添加成功之后,调用清空方法
            }
            else
            {
                MessageBox.Show("添加失败");
            }
}
```

#### 2.清空代码

```c#
//清空方法
public void ClearData()
 {
            txtContent.Text = "";
            txtDate.Text = "";
            txtName.Text = "";
            txtPerson.Text = "";
            txtPhone.Text = "";  
 }
```

#### 3.关闭代码

```c#
private void btnCancle_Click(object sender, EventArgs e)
{
      //取消,关闭当前窗体
      this.Close();
}
```

