using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamma.Utilities;
using QS.Project.Journal;
using QS.Utilities.Text;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Orders;

namespace Vodovoz.ViewModels.Journals.JournalNodes
{
	public class UndeliveredOrderJournalNode : JournalEntityNodeBase<UndeliveredOrder>
	{

		public int Id { get; set; }
		public int NumberInList { get; set; }
		public bool IsComment { get; set; }
		//public string StrId { get => NumberInList.ToString(); set {; } }
		public UndeliveryStatus StatusEnum { get; set; }

		public string DriverName { get => OldRouteListDriverName ?? "Заказ\nне в МЛ"; set {; } }

		public string Address { get; set; }

		public string Client { get; set; }

		public string ClientAndAddress => String.Format("{0}\n{1}", Client, Address);

		public string Reason { get; set; }

		public string OldOrderAuthor { get => PersonHelper.PersonNameWithInitials(OldOrderAuthorLastName, OldOrderAuthorFirstName, OldOrderAuthorMidleName); set {; } }
		public string Guilty { get; set; }

		public string UndeliveredOrderItems
		{
			get
			{
				if(OldOrder19LBottleQty > 0)
					return $"{OldOrder19LBottleQty:N0}";
				if(OldOrderGoodsToClient != null)
					return "к клиенту:\n" + OldOrderGoodsToClient;
				if(OldOrderGoodsFromClient != null)
					return "от клиента:\n" + OldOrderGoodsFromClient;
				return "Другие\nтовары";
			}
			set {; }
		}

		public string OldDeliverySchedule { get; set; }
		public string DriversCall
		{
			get
			{
				if(OldRouteListDriverName == null)
					return "Заказ\nне в МЛ";
				string time = DriverCallType != DriverCallType.NoCall ? DriverCallTime.ToString("HH:mm\n") : "";
				return String.Format("{0}{1}", time, DriverCallType.GetEnumTitle());
			}
			set {; }
		}
		public string OldOrderDeliveryDate { get => OldOrderDeliveryDateTime.ToString("d MMM"); set {; } }

		public string DispatcherCall
		{
			get => DispatcherCallTime.HasValue ? DispatcherCallTime.Value.ToString("HH:mm") : "Не\nзвонили";
			set {; }
		}

		public string TransferDateTime
		{
			get => NewOrderId > 0 ? NewOrderDeliveryDate?.ToString("d MMM\n") + NewOrderDeliverySchedule + "\n№" + NewOrderId.ToString() : "Новый заказ\nне создан";
			set {; }
		}
		public string ActionWithInvoice { get => NewOrderId > 0 ? NewOrderId.ToString() : "Новый заказ\nне создан"; set {; } }

		public string Registrator { get => PersonHelper.PersonNameWithInitials(RegistratorLastName, RegistratorFirstName, RegistratorMidleName); set {; } }

		public string UndeliveryAuthor { get => PersonHelper.PersonNameWithInitials(AuthorLastName, AuthorFirstName, AuthorMidleName); set {; } }
		public string Status { get => UndeliveryStatus.GetEnumTitle(); set {; } }
		public string FinedPeople { get => Fined ?? "Не выставлено"; set {; } }
		public string OldOrderStatus { get => String.Format("{0}\n\t↓\n{1}", StatusOnOldOrderCancel.GetEnumTitle(), OldOrderCurStatus.GetEnumTitle()); set {; } }

		public DateTime? DispatcherCallTime { get; set; }
		public DateTime DriverCallTime { get; set; }
		public DriverCallType DriverCallType { get; set; }
		public int DriverCallNr { get; set; }
		public string AuthorLastName { get; set; }
		public string AuthorFirstName { get; set; }
		public string AuthorMidleName { get; set; }
		public string EditorLastName { get; set; }
		public string EditorFirstName { get; set; }
		public string EditorMidleName { get; set; }
		public string RegistratorLastName { get; set; }
		public string RegistratorFirstName { get; set; }
		public string RegistratorMidleName { get; set; }
		public UndeliveryStatus UndeliveryStatus { get; set; }
		public GuiltyTypes GuiltySide { get; set; }
		public string GuiltyDepartment { get; set; }
		public string Fined { get; set; }
		public OrderStatus StatusOnOldOrderCancel { get; set; }
		public string InProcessAt { get; set; }

		//старый заказ
		public int OldOrderId { get; set; }
		public DateTime OldOrderDeliveryDateTime { get; set; }
		public string OldOrderAuthorLastName { get; set; }
		public string OldOrderAuthorFirstName { get; set; }
		public string OldOrderAuthorMidleName { get; set; }
		public decimal OldOrder19LBottleQty { get; set; }
		public string OldOrderGoodsToClient { get; set; }
		public string OldOrderGoodsFromClient { get; set; }
		public string OldRouteListDriverName { get; set; }
		public OrderStatus OldOrderCurStatus { get; set; }

		//новый заказ
		public int NewOrderId { get; set; }
		public DateTime? NewOrderDeliveryDate { get; set; }
		public string NewOrderDeliverySchedule { get; set; }
	}
}

