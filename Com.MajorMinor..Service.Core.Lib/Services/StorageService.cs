using Com.MM.Service.Core.Lib.Helpers;
using Com.MM.Service.Core.Lib.Models;
using Com.MM.Service.Core.Lib.ViewModels;
using Com.Moonlay.NetCore.Lib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;
using Com.MM.Service.Core.Lib.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Com.MM.Service.Core.Lib.Services
{
    public class StorageService : BasicService<CoreDbContext, Storage>, IMap<Storage, StorageViewModel>
    {
        public StorageService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        //public StorageService(IServiceProvider serviceProvider) : base(serviceProvider)
        //{
        //    DbContext.Database.SetCommandTimeout(1000 * 60 * 2);
        //}

        public override Tuple<List<Storage>, int, Dictionary<string, string>, List<string>> ReadModel(int Page = 1, int Size = 25, string Order = "{}", List<string> Select = null, string Keyword = null, string Filter = "{}")
        {
            IQueryable<Storage> Query = this.DbContext.Storages.AsNoTracking();
            Dictionary<string, object> FilterDictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(Filter);
            Query = ConfigureFilter(Query, FilterDictionary);
            Dictionary<string, string> OrderDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(Order);

            /* Search With Keyword */
            if (Keyword != null)
            {
                List<string> SearchAttributes = new List<string>()
                {
                    "Code", "Name", "ArticleRealizationOrder"
                };

                Query = Query.Where(General.BuildSearch(SearchAttributes), Keyword);
            }

            /* Const Select */
            List<string> SelectedFields = new List<string>()
            {
                "_id", "code", "name", "ArticleRealizationOrder"
            };



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
            //Pageable<Product> pageable = new Pageable<Product>(Query, Page - 1, Size);

            var totalData = Query.Count();
            Query = Query.Skip((Page - 1) * Size).Take(Size);

            List<Storage> Data = Query.ToList();

            //int TotalData = Query.TotalCount;

            return Tuple.Create(Data, totalData, OrderDictionary, SelectedFields);
        }

        public Tuple<List<StorageViewModel>, int, Dictionary<string, string>> GetDestination(int Page = 1, int Size = 25, string Order = "{}", List<string> select = null, string Keyword = null, string Filter = "{}")
        {


            IQueryable<StorageViewModel> Query = (from a in DbContext.Modules
                                                  join b in DbContext.ModuleDesstinations on a.Id equals b.ModuleId
                                                  join c in DbContext.Storages on b.DestinationValue equals c.UId

                                                  where
                                                  a.Code == Keyword

                                                  select new StorageViewModel
                                                  {
                                                      Code = c.Code,
                                                      Name = c.Name,
                                                      UId = c.UId,
                                                      _id = c.Id
                                                  }
                
                ).AsQueryable();



            Dictionary<string, object> FilterDictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(Filter);
            //Query = ConfigureFilter(Query, FilterDictionary);
            Dictionary<string, string> OrderDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(Order);



            //List<string> SelectedFields = new List<string>()
            //{
            //    "CorrectionNo", "CorrectionType", "SupplierName", "DONo"
            //};





            /* Pagination */
            Pageable<StorageViewModel> pageable = new Pageable<StorageViewModel>(Query, Page - 1, Size);
            List<StorageViewModel> Data = pageable.Data.ToList<StorageViewModel>();

            int TotalData = pageable.TotalCount;

            return Tuple.Create(Data, TotalData, OrderDictionary);
        }


        public Tuple<List<StorageViewModel>, int, Dictionary<string, string>> GetSource(int Page = 1, int Size = 25, string Order = "{}", List<string> select = null, string Keyword = null, string Filter = "{}")
        {


            IQueryable<StorageViewModel> Query = (from a in DbContext.Modules
                                                  join b in DbContext.ModuleSources on a.Id equals b.ModuleId
                                                  join c in DbContext.Storages on b.SourceValue equals c.UId

                                                  where
                                                  a.Code == Keyword

                                                  select new StorageViewModel
                                                  {
                                                      Code = c.Code,
                                                      Name = c.Name,
                                                      UId = c.UId,
                                                      _id = c.Id
                                                  }

                ).AsQueryable();



            Dictionary<string, object> FilterDictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(Filter);
            //Query = ConfigureFilter(Query, FilterDictionary);
            Dictionary<string, string> OrderDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(Order);



            //List<string> SelectedFields = new List<string>()
            //{
            //    "CorrectionNo", "CorrectionType", "SupplierName", "DONo"
            //};





            /* Pagination */
            Pageable<StorageViewModel> pageable = new Pageable<StorageViewModel>(Query, Page - 1, Size);
            List<StorageViewModel> Data = pageable.Data.ToList<StorageViewModel>();

            int TotalData = pageable.TotalCount;

            return Tuple.Create(Data, TotalData, OrderDictionary);
        }


        public StorageViewModel MapToViewModel(Storage storage)
        {
            StorageViewModel storageVM = new StorageViewModel();

            storageVM._id = storage.Id;
            storageVM.UId = storage.UId;
            storageVM._deleted = storage._IsDeleted;
            storageVM._active = storage.Active;
            storageVM._createdDate = storage._CreatedUtc;
            storageVM._createdBy = storage._CreatedBy;
            storageVM._createAgent = storage._CreatedAgent;
            storageVM._updatedDate = storage._LastModifiedUtc;
            storageVM._updatedBy = storage._LastModifiedBy;
            storageVM._updateAgent = storage._LastModifiedAgent;
            storageVM.Code = storage.Code;
            storageVM.Name = storage.Name;


            return storageVM;
        }

        public Storage MapToModel(StorageViewModel storageVM)
        {
            Storage storage = new Storage();

            storage.Id = storageVM._id;
            storage.UId = storageVM.UId;
            storage._IsDeleted = storageVM._deleted;
            storage.Active = storageVM._active;
            storage._CreatedUtc = storageVM._createdDate;
            storage._CreatedBy = storageVM._createdBy;
            storage._CreatedAgent = storageVM._createAgent;
            storage._LastModifiedUtc = storageVM._updatedDate;
            storage._LastModifiedBy = storageVM._updatedBy;
            storage._LastModifiedAgent = storageVM._updateAgent;
            storage.Code = storageVM.Code;
            storage.Name = storageVM.Name;

            return storage;
        }


        public Task<List<StorageViewModel>> GetStorage1(string storageId)
        {

            var storage = DbContext.Storages.Where(x => x.UId == storageId);
            return storage.Select(x => new StorageViewModel()
            {
                _id = x.Id,
                Code = x.Code,
                Name = x.Name
            }).ToListAsync();
        }

        public Storage GetStoragebyCode(string Code)
        {
            var storage = DbSet.Where(x => x.Code == Code).FirstOrDefault();
            return storage;
        }
    }
}
