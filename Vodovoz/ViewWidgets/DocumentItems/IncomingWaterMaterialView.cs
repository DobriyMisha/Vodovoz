﻿using System;
using System.Collections.Generic;
using System.Data.Bindings.Collections.Generic;
using Gtk;
using Gtk.DataBindings;
using NLog;
using QSOrmProject;
using QSTDI;
using Vodovoz.Domain;
using Vodovoz.Domain.Documents;

namespace Vodovoz
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class IncomingWaterMaterialView : Gtk.Bin
	{
		static Logger logger = LogManager.GetCurrentClassLogger ();

		private IUnitOfWorkGeneric<IncomingWater> documentUoW;

		public IUnitOfWorkGeneric<IncomingWater> DocumentUoW {
			get { return documentUoW; }
			set {
				if (documentUoW == value)
					return;
				documentUoW = value;
				if (DocumentUoW.Root.Materials == null)
					DocumentUoW.Root.Materials = new List<IncomingWaterMaterial> ();
				items = DocumentUoW.Root.ObservableMaterials;
				items.ElementChanged += Items_ElementChanged;
				treeMaterialsList.ColumnMappingConfig = FluentMappingConfig<IncomingWaterMaterial>.Create ()
					.AddColumn ("Наименование").AddTextRenderer (i => i.Name)
					.AddColumn ("На продукт")
					.AddNumericRenderer (i => i.OneProductAmountEdited).Editing ().WidthChars (10)
					.AddSetter ((c, i) => c.Digits = (uint)i.Nomenclature.Unit.Digits)
					.Adjustment (new Adjustment (0, 0, 1000000, 1, 100, 0))
					.AddTextRenderer (i => i.Nomenclature.Unit.Name, false)
					.AddColumn ("Всего")
					.AddNumericRenderer (i => i.Amount).Editing ().WidthChars (10)
					.AddSetter ((c, i) => c.Digits = (uint)i.Nomenclature.Unit.Digits)
					.Adjustment (new Adjustment (0, 0, 1000000, 1, 100, 0))
					.AddTextRenderer (i => i.Nomenclature.Unit.Name, false)
					.Finish ();

				treeMaterialsList.ItemsDataSource = items;

				CalculateTotal ();
			}
		}

		void OnOneProductColumnEdited (object o, EditedArgs args)
		{
			var node = (((treeMaterialsList.Model as TreeModelAdapter).Implementor as MappingsImplementor).GetNodeAtPath(new TreePath(args.Path)) as IncomingWaterMaterial);
			int amount;
			if (int.TryParse (args.NewText, out amount)) {
				node.OneProductAmount = amount;
			} else
				node.OneProductAmount = null;
		}

		void Items_ElementChanged (object aList, int[] aIdx)
		{
			CalculateTotal ();
		}

		public IncomingWaterMaterialView ()
		{
			this.Build ();
			treeMaterialsList.Selection.Changed += OnSelectionChanged;
		}

		void OnSelectionChanged (object sender, EventArgs e)
		{
			buttonDelete.Sensitive = treeMaterialsList.Selection.CountSelectedRows () > 0;
		}

		GenericObservableList<IncomingWaterMaterial> items;

		protected void OnButtonDeleteClicked (object sender, EventArgs e)
		{
			items.Remove (treeMaterialsList.GetSelectedObjects () [0] as IncomingWaterMaterial);
			CalculateTotal ();
		}

		protected void OnButtonAddClicked (object sender, EventArgs e)
		{
			ITdiTab mytab = TdiHelper.FindMyTab (this);
			if (mytab == null) {
				logger.Warn ("Родительская вкладка не найдена.");
				return;
			}

			//ICriteria ItemsCriteria = DocumentUoW.Session.CreateCriteria (typeof(Nomenclature))
			//	.Add (Restrictions.In ("Category", new[] { NomenclatureCategory.additional, NomenclatureCategory.equipment }));

			ReferenceRepresentation SelectDialog = new ReferenceRepresentation (new ViewModel.StockBalanceVM ());
			SelectDialog.Mode = OrmReferenceMode.Select;
			SelectDialog.ButtonMode = ReferenceButtonMode.None;
			SelectDialog.ObjectSelected += NomenclatureSelected;

			mytab.TabParent.AddSlaveTab (mytab, SelectDialog);
		}

		void NomenclatureSelected (object sender, ReferenceRepresentationSelectedEventArgs e)
		{
			var nomenctature = DocumentUoW.GetById<Nomenclature> (e.ObjectId);
			DocumentUoW.Root.AddMaterial (new IncomingWaterMaterial { 
				Nomenclature = nomenctature,
				Amount = 1
			});
		}

		void CalculateTotal ()
		{
			decimal total = 0;
			foreach (var item in documentUoW.Root.Materials) {
				total += item.Amount;
			}
			labelSum.LabelProp = String.Format ("Всего: {0}", total);
		}
	}
}

