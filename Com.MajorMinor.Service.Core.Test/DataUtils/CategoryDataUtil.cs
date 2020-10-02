using Com.MM.Service.Core.Lib;
using Com.MM.Service.Core.Lib.Models;
using Com.MM.Service.Core.Lib.Services;
using Com.MM.Service.Core.Lib.ViewModels;
using Com.MM.Service.Core.Test.Helpers;
using Com.MM.Service.Core.Test.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.MM.Service.Core.Test.DataUtils
{
    public class CategoryDataUtil : BasicDataUtil<CoreDbContext, ArticleCategoryService, ArticleCategory>, IEmptyData<ArticleCategoryViewModel>
    {
        public CategoryDataUtil(CoreDbContext dbContext, ArticleCategoryService service) : base(dbContext, service)
        {
        }

        public ArticleCategoryViewModel GetEmptyData()
        {
            return new ArticleCategoryViewModel();
        }

        public override ArticleCategory GetNewData()
        {
            string guid = Guid.NewGuid().ToString();
            return new ArticleCategory
            {
                Code = string.Format("CategoryName {0}", guid),
                Name = string.Format("CategoryName {0}", guid)
            };
        }

        public override async Task<ArticleCategory> GetTestDataAsync()
        {
            var data = GetNewData();
            await Service.CreateModel(data);
            return data;
        }
    }
}
