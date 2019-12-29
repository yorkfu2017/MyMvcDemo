/***********************************************************************
*  Copyright  (c) 2019$regisrereddorganization$ All Rights Reserved
*  CLR版本：  4.0.30319.42000
*  机器名称:  DELL
*  公司名称： MyMvcDemo.ModelOp
*  创建时间:  2019/12/28 20:45:07
*  文件名:    CustomerDataOp
*  版本号：    V1.0.0.0
*  唯一标识：  0cea45dd-7c45-464b-af8b-ccc5267dd2a8
*  当前的用户域： DELL
*  创建人：    admin
*  电子邮箱：  yorkdisfu@gmail.com

* 描述:
* 
* =======================================================================
* 
* 修改标记
* 修改时间:2019/12/28 20:45:07
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
    class CustomerDataOp : IDataOp<CustomerModel>
    {
        public void Create(CustomerModel Item)
        {
            throw new NotImplementedException();
        }

        public void Delete(CustomerModel Item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerModel> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerModel Item)
        {
            throw new NotImplementedException();
        }
    }
}
