﻿// -----------------------------------------------------------------------
//  <copyright file="IModuleHandler.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-23 2:31</last-date>
// -----------------------------------------------------------------------

using System;


namespace OSharp.Security
{
    /// <summary>
    /// 定义模块信息处理器
    /// </summary>
    public interface IModuleHandler<TModule, TModuleKey>
        where TModule : ModuleBase<TModuleKey>
        where TModuleKey : struct, IEquatable<TModuleKey>
    {
        /// <summary>
        /// 从程序集中获取模块信息
        /// </summary>
        void Initialize();
    }
}