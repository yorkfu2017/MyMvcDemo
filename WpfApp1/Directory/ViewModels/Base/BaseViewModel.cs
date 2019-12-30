/***********************************************************************
*  Copyright  (c) 2019$regisrereddorganization$ All Rights Reserved
*  CLR版本：  4.0.30319.42000
*  机器名称:  DELL
*  公司名称： WpfApp1.Directory.ViewModels
*  创建时间:  2019/12/30 18:11:20
*  文件名:    BaseViewModel
*  版本号：    V1.0.0.0
*  唯一标识：  00fd3859-211a-4851-a19e-cc2b8a22c4fc
*  当前的用户域： DELL
*  创建人：    admin
*  电子邮箱：  yorkdisfu@gmail.com

* 描述:
* 
* =======================================================================
* 
* 修改标记
* 修改时间:2019/12/30 18:11:20
* 修改人:admin
* 版本号：V1.0.0.0
*
* 描述
*
*
/***********************************************************************/
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Directory.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender,e)=> { };
    }
}
