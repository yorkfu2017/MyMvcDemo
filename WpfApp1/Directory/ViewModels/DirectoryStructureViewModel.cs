/***********************************************************************
*  Copyright  (c) 2019$regisrereddorganization$ All Rights Reserved
*  CLR版本：  4.0.30319.42000
*  机器名称:  DELL
*  公司名称： WpfApp1.Directory.ViewModels
*  创建时间:  2019/12/30 20:30:07
*  文件名:    DirectoryStructureViewModel
*  版本号：    V1.0.0.0
*  唯一标识：  2d8926bf-1754-4272-b3f1-09d59e0e13bc
*  当前的用户域： DELL
*  创建人：    admin
*  电子邮箱：  yorkdisfu@gmail.com

* 描述:
* 
* =======================================================================
* 
* 修改标记
* 修改时间:2019/12/30 20:30:07
* 修改人:admin
* 版本号：V1.0.0.0
*
* 描述
*
*
/***********************************************************************/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Directory.ViewModels
{
    //the view model for the applications main directory view 
    public class DirectoryStructureViewModel:BaseViewModel
    {
        public ObservableCollection<DirectoryItemViewModel> Items { get; set; }
        
        public DirectoryStructureViewModel()
        {
            var children = DirectoryStructure.GetLogicalDrives();
            this.Items = new ObservableCollection<DirectoryItemViewModel>(children.Select(drive =>new DirectoryItemViewModel(drive.FullPath,Data.DirectoryItemType.Drive)));
        }
    }
}
