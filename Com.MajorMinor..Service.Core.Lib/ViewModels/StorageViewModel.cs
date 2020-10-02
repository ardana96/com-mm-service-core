using Com.MM.Service.Core.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MM.Service.Core.Lib.ViewModels
{
    public class StorageViewModel : BasicViewModelOld
    {
        public string Code { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsCentral { get; set; }
    }
}
