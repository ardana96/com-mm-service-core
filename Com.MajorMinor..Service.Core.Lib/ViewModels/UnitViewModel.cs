using Com.MM.Service.Core.Lib.Helpers;
using System;

namespace Com.MM.Service.Core.Lib.ViewModels
{
    public class UnitViewModel  : BasicViewModelOld
    {
        public string code { get; set; }

        public DivisionViewModel division { get; set; }

        public string name { get; set; }

        public string description { get; set; }
        public string cOACode { get; set; }
    }
}
