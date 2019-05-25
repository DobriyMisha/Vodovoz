﻿using QS.Dialog.Gtk;
using QS.DomainModel.UoW;
using Vodovoz.Domain.Client;

namespace Vodovoz.Dialogs.Client
{
	public partial class DeliveryPointCategoryDlg : EntityDialogBase<DeliveryPointCategory>
	{
		public DeliveryPointCategoryDlg()
		{
			this.Build();
			UoWGeneric = UnitOfWorkFactory.CreateWithNewRoot<DeliveryPointCategory>();
			ConfigureDlg();
		}

		public DeliveryPointCategoryDlg(DeliveryPointCategory sub) : this(sub.Id) { }

		public DeliveryPointCategoryDlg(int id)
		{
			this.Build();
			UoWGeneric = UnitOfWorkFactory.CreateForRoot<DeliveryPointCategory>(id);
			ConfigureDlg();
		}

		void ConfigureDlg()
		{
			SetArchive();
			entName.Binding.AddBinding(Entity, e => e.Name, w => w.Text).InitializeFromSource();
			chkIsArchive.Binding.AddBinding(Entity, e => e.IsArchive, w => w.Active).InitializeFromSource();
		}

		void SetArchive()
		{
			entName.Sensitive = chkIsArchive.Sensitive = !Entity.IsArchive;
		}

		public override bool Save()
		{
			UoWGeneric.Save();
			return true;
		}
	}
}