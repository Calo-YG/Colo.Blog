﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calo.Blog.EntityCore.DataBase.EntityBase
{
    public class AutiedEntity<T> :Entity<T> where T : new()
    {
        /// <summary>
        /// 创建人id
        /// </summary>
        public T? CreatorUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? CreateorUserName { get; set; }

        public string? UpdaterUserId { get; set; }

        public T? UpdateUserId { get; set; }
    }
}
