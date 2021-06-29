using System;
using QS.Views.GtkUI;
using Vodovoz.ViewModels.ViewModels.Orders;

namespace Vodovoz.Views.Orders
{
	public partial class UndeliveredOrderView : TabViewBase<UndeliveredOrderViewModel>
	{
		public UndeliveredOrderView(UndeliveredOrderViewModel viewModel) : base(viewModel)
		{
			this.Build();
			Configure();
		}

		private void Configure()
		{
		}
	}
}
