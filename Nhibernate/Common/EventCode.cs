﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum EventCode:byte //区分服务器向客户端发送事件的类型
    {
        NewPlayer,
        SyncPos
    }
}
