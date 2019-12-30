/***********************************************************************
*  Copyright  (c) 2019$regisrereddorganization$ All Rights Reserved
*  CLR版本：  4.0.30319.42000
*  机器名称:  DELL
*  公司名称： WpfApp1.Directory
*  创建时间:  2019/12/30 14:55:22
*  文件名:    DirectoryStructure
*  版本号：    V1.0.0.0
*  唯一标识：  0604bf40-ec34-4c7b-aa9e-fde7b783911d
*  当前的用户域： DELL
*  创建人：    admin
*  电子邮箱：  yorkdisfu@gmail.com

* 描述:
* 
* =======================================================================
* 
* 修改标记
* 修改时间:2019/12/30 14:55:22
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
using WpfApp1.Directory.Data;

namespace WpfApp1.Directory
{
    public class DirectoryStructure
    {
        public static  List<DirectoryItem> GetLogicalDrives()
        {
           return  System.IO.Directory.GetLogicalDrives().Select(
                drive => new DirectoryItem { FullPath = drive, Type = DirectoryItemType.Drive }).ToList();
        }
        public static List<DirectoryItem> GetDirectoryContents(string fullPath)
        {
            var items = new List<DirectoryItem>();
          
            try
            {

                var dirs = System.IO.Directory.GetDirectories(fullPath);
                if (dirs.Length > 0)
                {
                    items.AddRange(
                        dirs.Select(dir =>new DirectoryItem { FullPath=dir,Type= DirectoryItemType.Folder})
                        );
                }
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                var fs = System.IO.Directory.GetFiles(fullPath);
                if (fs.Length>0)
                {
                    items.AddRange(fs.Select(file => new DirectoryItem {FullPath = file,Type = DirectoryItemType.File }));

                }
            }
            catch (Exception)
            {

                throw;
            }
            return items;
            //diretories.ForEach(directoryPath =>
            //{
            //    var subItem = new TreeViewItem()
            //    {
            //        //set header as Folder name
            //        //Header = Path.GetDirectoryName(directoryPath),
            //        Header = DirectoryStructure.GetFileFolderName(directoryPath),
            //        //and tag a full path 
            //        Tag = directoryPath
            //    };
            //    //AddChild dummy item so we can expand folder 
            //    subItem.Items.Add(null);
            //    subItem.Expanded += Folder_Expanded;

            //    item.Items.Add(subItem);
            //});


        }
        public static string GetFileFolderName(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return string.Empty;
            }

            var normalizedPath = path.Replace('/', '\\');
            var lastIndex = normalizedPath.LastIndexOf('\\');
            if (lastIndex <= 0)
            {
                return path;
            }
            return path.Substring(lastIndex + 1);

        }
    }
}
