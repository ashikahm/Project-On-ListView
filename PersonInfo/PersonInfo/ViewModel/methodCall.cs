using PersonInfo.model;
using System;
using System.Collections.Generic;
using System.Text;
using PersonInfo.Services;

namespace PersonInfo.ViewModel
{
    internal class methodCall
    {
        public List<Information> GetInfo { get; set; }
        public methodCall()
        {
            GetInfo = new ServiceClass().getInfo();
        }
    }
}
