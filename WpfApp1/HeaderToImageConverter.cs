/***********************************************************************
*  Copyright  (c) 2019$regisrereddorganization$ All Rights Reserved
*  CLR版本：  4.0.30319.42000
*  机器名称:  DELL
*  公司名称： WpfApp1
*  创建时间:  2019/12/30 13:45:51
*  文件名:    HeaderToImageConverter
*  版本号：    V1.0.0.0
*  唯一标识：  984f69d2-2689-4608-b505-71069e8410a4
*  当前的用户域： DELL
*  创建人：    admin
*  电子邮箱：  yorkdisfu@gmail.com

* 描述:
* 
* =======================================================================
* 
* 修改标记
* 修改时间:2019/12/30 13:45:51
* 修改人:admin
* 版本号：V1.0.0.0
*
* 描述
*
*
/***********************************************************************/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    /// <summary>
    /// converts a full path to a specific image type of 
    /// </summary>
    /// []
    [ValueConversion(typeof(string),typeof(BitmapImage))]
    public class HeaderToImageConverter : IValueConverter
    {
        public static HeaderToImageConverter Instance = new HeaderToImageConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //return new object();
            var path = (string)value;
            if (path ==null)
            {
                return null;
            }
            var name = WpfTreeView.GetFileFolderName(path);
            var image = "Images/driver.jpg";
            if (string.IsNullOrEmpty(name))
            {
                image = "Images/f1.jpg";
            }
            else if(new FileInfo(path).Attributes.HasFlag(FileAttributes.Directory))
            {
                image = "Images/f2.jpg";
            }
           
            return new BitmapImage(new Uri($"pack://application:,,,/{image}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
