/***********************************************************************
*  Copyright  (c) 2019$regisrereddorganization$ All Rights Reserved
*  CLR版本：  4.0.30319.42000
*  机器名称:  DELL
*  公司名称： MyMvcDemo.ModelOp
*  创建时间:  2019/12/28 21:12:53
*  文件名:    OrderDataOp
*  版本号：    V1.0.0.0
*  唯一标识：  26332efb-22b7-4c35-bf22-5e632ae86a9b
*  当前的用户域： DELL
*  创建人：    admin
*  电子邮箱：  yorkdisfu@gmail.com

* 描述:
* 
* =======================================================================
* 
* 修改标记
* 修改时间:2019/12/28 21:12:53
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
using MyMvcDemo.Models;

namespace MyMvcDemo.ModelOp
{
    class OrderDataOp : IDataOp<OrderModel>
    {
        public void Create(OrderModel Item)
        {
            throw new NotImplementedException();
        }

        public void Delete(OrderModel Item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderModel> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderModel Item)
        {
            throw new NotImplementedException();
        }
    }
}
