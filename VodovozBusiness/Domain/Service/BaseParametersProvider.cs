﻿using System;
using Gdk;
using QS.DomainModel.UoW;
using QSSupportLib;
using Vodovoz.Domain.Orders;
using Vodovoz.Domain.StoredResources;
using Vodovoz.Services;

namespace Vodovoz.Core.DataService
{
	public class BaseParametersProvider : IStandartNomenclatures , IImageProvider
	{

		public int GetForfeitId()
		{
			if(!MainSupport.BaseParameters.All.ContainsKey("forfeit_nomenclature_id")) {
				throw new InvalidProgramException("В параметрах базы не настроена номенклатура бутыли по умолчанию (forfeit_nomenclature_id).");
			}
			return int.Parse(MainSupport.BaseParameters.All["forfeit_nomenclature_id"]);
		}

		public Pixbuf GetCrmIndicator(IUnitOfWork uow)
		{
			int indicatorID = GetCrmInicatorId();
			return uow.GetById<StoredImageResource>(indicatorID)?.GetPixbufImg();
		}

		private int GetCrmInicatorId()
		{
			if(!MainSupport.BaseParameters.All.ContainsKey("crm_importance_indicator_id")) {
				throw new InvalidProgramException("В параметрах базы не настроен индикатор важности задачи для CRM (crm_importance_indicator_id).");
			}
			return int.Parse(MainSupport.BaseParameters.All["crm_importance_indicator_id"]);
		}
	}
}
