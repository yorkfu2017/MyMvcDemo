/***********************************************************************
*  Copyright  (c) 2019$regisrereddorganization$ All Rights Reserved
*  CLR版本：  4.0.30319.42000
*  机器名称:  DELL
*  公司名称： MyMvcDemo
*  创建时间:  2019/12/28 20:55:12
*  文件名:    Northwind
*  版本号：    V1.0.0.0
*  唯一标识：  0cfad191-3468-4e34-b569-4d835b318bd3
*  当前的用户域： DELL
*  创建人：    admin
*  电子邮箱：  yorkdisfu@gmail.com

* 描述:
* 
* =======================================================================
* 
* 修改标记
* 修改时间:2019/12/28 20:55:12
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
using MyMvcDemo.ModelOp;
using MyMvcDemo.Models;

namespace MyMvcDemo
{
    class Northwind
    {
        private IDataOp<CustomerModel> _customerOp = null;
        private IDataOp<OrderModel> _orderOp = null;
        public IDataOp<CustomerModel> Customers
        {
            get
            {
                if (this._customerOp ==null)
                {
                    this._customerOp = new CustomerDataOp();   
                }
                return this._customerOp;
            }
        }
        public IDataOp<OrderModel> Orders
        {
            get
            {
                if (this._orderOp ==null)
                {
                    this._orderOp = new OrderDataOp();
                }
                return this._orderOp; 
            }
        }
    }
}
