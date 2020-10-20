﻿using Com.MM.Service.Core.Lib.Helpers;
using Com.MM.Service.Core.Lib.Interfaces;
using Com.MM.Service.Core.Lib.Models.Account_and_Roles;
using Com.MM.Service.Core.Lib.ViewModels.Account_and_Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MM.Service.Core.Lib.Services.Account_and_Roles
{
    public class PermissionService : BasicService<CoreDbContext, Permission>, IMap<Permission, PermissionViewModel>
    {
        public PermissionService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public Permission MapToModel(PermissionViewModel viewModel)
        {
            Permission model = new Permission();
            PropertyCopier<PermissionViewModel, Permission>.Copy(viewModel, model);
            model.UnitId = viewModel.unit._id;
            model.UnitCode = viewModel.unit.code;
            model.Unit = viewModel.unit.name;
            return model;
        }

        public PermissionViewModel MapToViewModel(Permission model)
        {
            PermissionViewModel viewModel = new PermissionViewModel();
            PropertyCopier<Permission, PermissionViewModel>.Copy(model, viewModel);
            viewModel.unit._id = model.UnitId;
            viewModel.unit.name = model.Unit;
            viewModel.unit.code = model.UnitCode;
            return viewModel;
        }

        public override Tuple<List<Permission>, int, Dictionary<string, string>, List<string>> ReadModel(int Page = 1, int Size = 25, string Order = "{}", List<string> Select = null, string Keyword = null, string Filter = "{}")
        {
            throw new NotImplementedException();
        }

        public override void OnCreating(Permission model)
        {
            base.OnCreating(model);
            model._CreatedAgent = "core-service";
            model._CreatedBy = this.Username;
        }
        public override void OnUpdating(int id, Permission model)
        {
            base.OnUpdating(id, model);
            model._LastModifiedAgent = "core-service";
            model._LastModifiedBy = this.Username;
        }

        public override void OnDeleting(Permission model)
        {
            base.OnDeleting(model);
            model._LastModifiedAgent = "core-service";
            model._LastModifiedBy = this.Username;
            model._DeletedAgent = "core-service";
            model._DeletedBy = this.Username;
        }
    }
}
