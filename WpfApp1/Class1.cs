/***********************************************************************
*  Copyright  (c) 2019$regisrereddorganization$ All Rights Reserved
*  CLR版本：  4.0.30319.42000
*  机器名称:  DELL
*  公司名称： WpfApp1
*  创建时间:  2019/12/30 16:41:18
*  文件名:    Class1
*  版本号：    V1.0.0.0
*  唯一标识：  cead0536-35d4-43ad-a6d6-3266ec38bf47
*  当前的用户域： DELL
*  创建人：    admin
*  电子邮箱：  yorkdisfu@gmail.com

* 描述:
* 
* =======================================================================
* 
* 修改标记
* 修改时间:2019/12/30 16:41:18
* 修改人:admin
* 版本号：V1.0.0.0
*
* 描述
*
*
/***********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using PropertyChanged;

namespace WpfApp1
{
    [AddINotifyPropertyChangedInterface]
    class Class1 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
        private string myTest;
       
        public string Test
        {
            get;set;
            //因为安装了propertyChanged,所以如下可以注释了
            //get { return myTest; }
            //set {
            //    if (myTest == value)
            //    {
            //        return;
            //    }
            //    myTest = value;
            //    PropertyChanged(this,new PropertyChangedEventArgs(nameof(Test)));
            //}
        }

        
        
       //public Class1()
       // {
       //     Task.Run(async () =>
       //     {
       //         int i = 0;
       //         while (true)
       //         {
       //             await Task.Delay(200);
       //             Test = (i++).ToString();
       //             PropertyChanged(this,new PropertyChangedEventArgs("Test"));
       //         }
       //     });
       // }
        //public override string ToString()
        //{
        //    return "Hello World";
        //}

    }
}
