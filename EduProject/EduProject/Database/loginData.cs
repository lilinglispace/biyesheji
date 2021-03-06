﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EduProject.Areas.User.Models;
using System.Data;

namespace EduProject.Database
{
    public class loginData
    {
        BShopEntities shopEntity = new BShopEntities();
        //登录获取用户个人信息
        public IEnumerable<User> getLoginData(string username, string password)
        {
            var Login_user = shopEntity.User.Where(c => c.UName == username && c.Password == password).ToList();         
            return Login_user;
                    
        }
        
        //登录用户个人信息
        public IEnumerable<User> GetUserInfo(string userName)
        {
            var UserInfoDetail = shopEntity.User.Where(c => c.UName == userName).ToList();
            return UserInfoDetail;
        }
    }
}