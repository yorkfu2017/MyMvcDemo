/***********************************************************************
*  Copyright  (c) 2019$regisrereddorganization$ All Rights Reserved
*  CLR版本：  4.0.30319.42000
*  机器名称:  DELL
*  公司名称： WpfApp1.Directory.ViewModels
*  创建时间:  2019/12/30 20:09:13
*  文件名:    RelayCommand
*  版本号：    V1.0.0.0
*  唯一标识：  a10b0b5b-6d3d-4777-98e6-7d34a469a1ce
*  当前的用户域： DELL
*  创建人：    admin
*  电子邮箱：  yorkdisfu@gmail.com

* 描述:
* 
* =======================================================================
* 
* 修改标记
* 修改时间:2019/12/30 20:09:13
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
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.Directory.ViewModels
{
    class RelayCommand : ICommand
    {
        private Action mAction;
        public event EventHandler CanExecuteChanged =(sender,e)=> { };

        public RelayCommand(Action action )
        {
            mAction = action;
        }

        public bool CanExecute(object parameter) 
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
        }
    }
}
