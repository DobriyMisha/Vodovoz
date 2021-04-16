﻿using Gtk;
using Vodovoz.ViewModels;
using Gamma.ColumnConfig;
using QS.Views.GtkUI;
using Vodovoz.Domain.Payments;
using QSProjectsLib;

namespace Vodovoz.Views
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class PaymentLoaderView : TabViewBase<PaymentLoaderViewModel>
	{
		static Gdk.Color colorPink = new Gdk.Color(0xff, 0xc0, 0xc0);
		static Gdk.Color colorWhite = new Gdk.Color(0xff, 0xff, 0xff);
		static Gdk.Color colorLightGreen = new Gdk.Color(0xc0, 0xff, 0xc0);

		public PaymentLoaderView(PaymentLoaderViewModel paymentLoaderViewModel) : base(paymentLoaderViewModel)
		{
			this.Build();
			Configure();
		}

		private void Configure()
        {
            var txtFilter = new FileFilter();
            txtFilter.AddPattern("*.txt");
            txtFilter.Name = "Текстовые файлы (*.txt)";
            var allFilter = new FileFilter();
            allFilter.AddPattern("*");
            allFilter.Name = "Все файлы";
            fileChooserBtn.AddFilter(txtFilter);
            fileChooserBtn.AddFilter(allFilter);

            btnUpload.Clicked += (sender, e) => ViewModel.SaveCommand.Execute(ViewModel.ObservablePayments);
            btnUpload.Binding.AddBinding(ViewModel, v => v.IsNotAutoMatchingMode, w => w.Sensitive).InitializeFromSource();
            btnCancel.Clicked += (sender, e) => ViewModel.Close(false, QS.Navigation.CloseSource.Cancel);
            btnCancel.Binding.AddBinding(ViewModel, v => v.IsNotAutoMatchingMode, w => w.Sensitive).InitializeFromSource();

            ViewModel.UpdateProgress += UpdateProgress;

            btnReadFile.Clicked += (sender, e) => ViewModel.ParseCommand.Execute(fileChooserBtn.Filename);
            btnReadFile.Binding.AddBinding(ViewModel, vm => vm.IsNotAutoMatchingMode, v => v.Sensitive).InitializeFromSource();

            ConfigureTree();
        }

        private void ConfigureTree()
        {
            treeDocuments.ColumnsConfig = FluentColumnsConfig<Payment>.Create()
                .AddColumn("№")
                    .AddTextRenderer(x => x.PaymentNum.ToString())
                .AddColumn("Дата")
                    .AddTextRenderer(x => x.Date.ToShortDateString())
                .AddColumn("Cумма")
                    .AddTextRenderer(x => x.Total.ToString())
                .AddColumn("Заказы")
                    .AddTextRenderer(x => x.NumOrders)
                .AddColumn("Плательщик")
                    .AddTextRenderer(x => x.CounterpartyName)
                    .WrapWidth(450)
                    .WrapMode(Pango.WrapMode.WordChar)
                .AddColumn("Получатель")
                    .AddTextRenderer(x => x.Organization.FullName)
                .AddColumn("Назначение платежа")
                    .AddTextRenderer(x => x.PaymentPurpose)
                    .WrapWidth(600)
                    .WrapMode(Pango.WrapMode.WordChar)
                .AddColumn("Категория дохода/расхода")
                    .AddComboRenderer(x => x.ProfitCategory)
                    .SetDisplayFunc(x => x.Name)
                    .FillItems(ViewModel.ProfitCategories)
                    .Editing()
                .AddColumn("")
                .RowCells().AddSetter<CellRenderer>(
                    (c, n) =>
                    {
                        var color = colorLightGreen;
                        if (n.Status != PaymentState.distributed)
                            color = colorPink;
                        c.CellBackgroundGdk = color;
                    })
                .Finish();

            treeDocuments.Binding.AddBinding(ViewModel, vm => vm.ObservablePayments, w => w.ItemsDataSource).InitializeFromSource();
        }

        private void UpdateProgress(string msg, double progress)
		{
			if(progress == 0)
				progressbar1.Fraction = 0;

			progressbar1.Fraction += progress;
			progressbar1.Text = msg;
			QSMain.WaitRedraw();
		}
	}
}
