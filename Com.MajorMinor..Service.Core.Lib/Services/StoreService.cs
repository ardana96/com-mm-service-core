using Com.MajorMinor.Service.Core.Lib.ViewModels;
using Com.MM.Service.Core.Lib.Helpers;
using Com.MM.Service.Core.Lib.Interfaces;
using Com.MM.Service.Core.Lib.Models;
using Com.MM.Service.Core.Lib.ViewModels;
using Com.Moonlay.NetCore.Lib;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Com.MM.Service.Core.Lib.Services
{
    public class StoreService : BasicService<CoreDbContext, Store>, IMap<Store, StoreViewModel>
    {
        public StoreService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public override Tuple<List<Store>, int, Dictionary<string, string>, List<string>> ReadModel(int Page = 1, int Size = 25, string Order = "{}", List<string> Select = null, string Keyword = null, string Filter = "{}")
        {
            IQueryable<Store> Query = this.DbContext.Stores;
            Dictionary<string, object> FilterDictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(Filter);
            Query = ConfigureFilter(Query, FilterDictionary);
            Dictionary<string, string> OrderDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(Order);

            /* Search With Keyword */
            if (Keyword != null)
            {
                List<string> SearchAttributes = new List<string>()
                {
                     "Code","Name"
                };

                Query = Query.Where(General.BuildSearch(SearchAttributes), Keyword);
            }

            /* Const Select */
            List<string> SelectedFields = new List<string>()
            {
                 "_id","code", "name", "description","address","city","closedDate","monthlyTotalCost","onlineOffline","openedDate",
                 "pic","phone","salesCapital","salesCategory","salesTarget","status","storeArea","storeCategory","storeWide"
            };

            //Query = Query
            //    .Select(b => new Store
            //    {
            //        Id = b.Id,
            //        Code = b.Code,
            //        Name = b.Name
            //    });

            /* Order */
            if (OrderDictionary.Count.Equals(0))
            {
                OrderDictionary.Add("_updatedDate", General.DESCENDING);

                Query = Query.OrderByDescending(b => b._LastModifiedUtc); /* Default Order */
            }
            else
            {
                string Key = OrderDictionary.Keys.First();
                string OrderType = OrderDictionary[Key];
                string TransformKey = General.TransformOrderBy(Key);

                BindingFlags IgnoreCase = BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance;

                Query = OrderType.Equals(General.ASCENDING) ?
                    Query.OrderBy(b => b.GetType().GetProperty(TransformKey, IgnoreCase).GetValue(b)) :
                    Query.OrderByDescending(b => b.GetType().GetProperty(TransformKey, IgnoreCase).GetValue(b));
            }

            /* Pagination */
            Pageable<Store> pageable = new Pageable<Store>(Query, Page - 1, Size);
            List<Store> Data = pageable.Data.ToList<Store>();

            int TotalData = pageable.TotalCount;

            return Tuple.Create(Data, TotalData, OrderDictionary, SelectedFields);
        }
        public StoreViewModel MapToViewModel(Store season)
        {
            StoreViewModel seasonVM = new StoreViewModel();

            seasonVM._id = season.Id;
            seasonVM.UId = season.Uid;
            seasonVM._deleted = season._IsDeleted;
            seasonVM._active = season.Active;
            seasonVM._createdDate = season._CreatedUtc;
            seasonVM._createdBy = season._CreatedBy;
            seasonVM._createAgent = season._CreatedAgent;
            seasonVM._updatedDate = season._LastModifiedUtc;
            seasonVM._updatedBy = season._LastModifiedBy;
            seasonVM._updateAgent = season._LastModifiedAgent;
            seasonVM.code = season.Code;
            seasonVM.name = season.Name;
            seasonVM.address = season.Address;
            seasonVM.city = season.City;
            seasonVM.closedDate = season.ClosedDate;
            seasonVM.description = season.Description;
            seasonVM.monthlyTotalCost = season.MonthlyTotalCost;
            seasonVM.onlineOffline = season.OnlineOffline;
            seasonVM.openedDate = season.OpenedDate;
            seasonVM.phone = season.Phone;
            seasonVM.pic = season.Pic;
            seasonVM.salesCapital = season.SalesCapital;
            seasonVM.salesCategory = season.SalesCategory;
            seasonVM.salesTarget = season.SalesTarget;
            seasonVM.status = season.Status;
            seasonVM.storeArea = season.StoreArea;
            seasonVM.storeCategory = season.StoreCategory;
            seasonVM.storeWide = season.StoreWide;
            


            return seasonVM;
        }

        public Store MapToModel(StoreViewModel seasonVM)
        {
            Store season = new Store();

            season.Id = seasonVM._id;
            season.Uid = seasonVM.UId;
            season._IsDeleted = seasonVM._deleted;
            season.Active = seasonVM._active;
            season._CreatedUtc = seasonVM._createdDate;
            season._CreatedBy = seasonVM._createdBy;
            season._CreatedAgent = seasonVM._createAgent;
            season._LastModifiedUtc = seasonVM._updatedDate;
            season._LastModifiedBy = seasonVM._updatedBy;
            season._LastModifiedAgent = seasonVM._updateAgent;
            season.Code = seasonVM.code;
            season.Name = seasonVM.name;
            season.Address = seasonVM.address;
            season.City = season.City;
            season.ClosedDate = seasonVM.closedDate;
            season.Description = seasonVM.description;
            season.MonthlyTotalCost = seasonVM.monthlyTotalCost;
            season.OnlineOffline = seasonVM.onlineOffline;
            season.OpenedDate = seasonVM.openedDate;
            season.Phone = seasonVM.phone;
            season.Pic = seasonVM.pic;
            season.SalesCapital = seasonVM.salesCapital;
            season.SalesCategory = seasonVM.salesCategory;
            season.SalesTarget = seasonVM.salesTarget;
            season.Status = seasonVM.status;
            season.StoreArea = seasonVM.storeArea;
            season.StoreCategory = seasonVM.storeCategory;
            season.StoreWide = seasonVM.storeWide;
            

            return season;
        }

        public sealed class MaterialMap : ClassMap<StoreViewModel>
        {
            public MaterialMap()
            {
                Map(c => c.code).Index(0);
                Map(c => c.name).Index(1);
            }
        }

        public Task<List<Store>> GetStoreByCategory(string category)
        {
            var store = (from a in DbContext.Stores
                         where a.StoreCategory.Contains((string.IsNullOrWhiteSpace(category) ? a.StoreCategory : category))
                         select a).ToListAsync();
            return store;
        }

        public Task<Store> GetStoreByCode(string code)
        {
            var store = (from a in DbContext.Stores
                         where a.Code.Contains((string.IsNullOrWhiteSpace(code) ? a.Code : code))
                         select a).FirstOrDefaultAsync();
            return store;
        }

        public Task<StoreStorageViewModel> GetStoreStorageByCode(string code)
        {
            var store = (from a in DbContext.Stores
                         join b in DbContext.Storages on a.Code equals b.Code
                         where a.Code.Contains((string.IsNullOrWhiteSpace(code) ? a.Code : code))
                         select new StoreStorageViewModel{
                             address = a.Address,
                             city = a.City,
                             closedDate = a.ClosedDate,
                             code = a.Code,
                             description = a.Description,
                             Id = a.Id,
                             monthlyTotalCost = a.MonthlyTotalCost,
                             name = a.Name,
                             onlineOffline = a.OnlineOffline,
                             openedDate = a.OpenedDate,
                             phone = a.Phone,
                             pic = a.Pic,
                             salesCapital = a.SalesCapital,
                             salesCategory = a.SalesCategory,
                             salesTarget = a.SalesTarget,
                             status = a.Status,
                             storeArea = a.StoreArea,
                             storeCategory = a.StoreCategory,
                             storeWide = a.StoreWide,
                             storage = new StorageViewModel
                             {
                                 Address = b.Address,
                                 Code = b.Code,
                                 Description = b.Description,
                                 IsCentral = b.IsCentral,
                                 Name = b.Name,
                                 Phone = b.Phone,
                                 _id = b.Id
                                 
                             }
                            
                         }).FirstOrDefaultAsync();
            return store;
        }
    }
}
