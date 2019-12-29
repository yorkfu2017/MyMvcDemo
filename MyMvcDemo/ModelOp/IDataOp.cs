/***********************************************************************
*  Copyright  (c) 2019$regisrereddorganization$ All Rights Reserved
*  CLR版本：  4.0.30319.42000
*  机器名称:  DELL
*  公司名称： MyMvcDemo.ModelOp
*  创建时间:  2019/12/28 20:41:11
*  文件名:    IModelOp
*  版本号：    V1.0.0.0
*  唯一标识：  a2c5e06d-460e-46c8-801e-1e102fe4f65c
*  当前的用户域： DELL
*  创建人：    admin
*  电子邮箱：  yorkdisfu@gmail.com

* 描述:
* 
* =======================================================================
* 
* 修改标记
* 修改时间:2019/12/28 20:41:11
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

namespace MyMvcDemo.ModelOp
{
    public interface IDataOp<T> where T:class ,new()
    {
        IEnumerable<T> Get();
        void Create(T Item);
        void Update(T Item);
        void Delete(T Item);

    }
}
