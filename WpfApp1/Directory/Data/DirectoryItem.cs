/***********************************************************************
*  Copyright  (c) 2019$regisrereddorganization$ All Rights Reserved
*  CLR版本：  4.0.30319.42000
*  机器名称:  DELL
*  公司名称： WpfApp1.Directory.Data
*  创建时间:  2019/12/30 14:56:41
*  文件名:    DirectoryItem
*  版本号：    V1.0.0.0
*  唯一标识：  a547ce18-2c5f-4b18-9850-61278c57662b
*  当前的用户域： DELL
*  创建人：    admin
*  电子邮箱：  yorkdisfu@gmail.com

* 描述:
* 
* =======================================================================
* 
* 修改标记
* 修改时间:2019/12/30 14:56:41
* 修改人:admin
* 版本号：V1.0.0.0
*
* 描述
/***********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApp1.Directory.Data
{
    public class DirectoryItem
    {
        public DirectoryItemType Type { get; set; }
        public string FullPath { get; set; }
        public string Name { get {
                return this.Type == DirectoryItemType.Drive?this.FullPath: DirectoryStructure.GetFileFolderName(this.FullPath);

            }  }
    }
}
