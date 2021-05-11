using System;
using System.Linq;
using QS.DomainModel.UoW;
using Vodovoz.Domain;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Orders;
using Vodovoz.Domain.Orders.OrdersWithoutShipment;
using Vodovoz.Domain.Organizations;
using Vodovoz.Parameters;
using Vodovoz.Services;

namespace Vodovoz.Models
{
    public class Stage2OrganizationProvider : IOrganizationProvider
    {
        private readonly IOrganizationParametersProvider organizationParametersProvider;
        private readonly IOrderParametersProvider orderParametersProvider;

        public Stage2OrganizationProvider(
            IOrganizationParametersProvider organizationParametersProvider,
            IOrderParametersProvider orderParametersProvider
            )
        {
            this.organizationParametersProvider = organizationParametersProvider ?? throw new ArgumentNullException(nameof(organizationParametersProvider));
            this.orderParametersProvider = orderParametersProvider ?? throw new ArgumentNullException(nameof(orderParametersProvider));
        }
        
        public Organization GetOrganization(IUnitOfWork uow, Order order)
        {
            if (uow == null) throw new ArgumentNullException(nameof(uow));
            if (order == null) throw new ArgumentNullException(nameof(order));
            
            if(IsOnlineStoreOrder(order)) {
                return GetOrganizationForOnlineStore(uow);
            }
            
            if (order.SelfDelivery || order.DeliveryPoint == null) {
                return GetOrganizationForSelfDelivery(uow, order);
            }
            
            return GetOrganizationForOtherOptions(uow, order);
        }

        private Organization GetOrganizationForSelfDelivery(IUnitOfWork uow, Order order)
        {
            int organizationId = 0;
            switch(order.PaymentType) {
                case PaymentType.barter:
                case PaymentType.cashless:
                case PaymentType.ContractDoc:
                    organizationId = organizationParametersProvider.VodovozOrganizationId;
                    break;
                case PaymentType.cash:
                case PaymentType.Terminal:
                case PaymentType.ByCard:
                    organizationId = organizationParametersProvider.VodovozSouthOrganizationId;
                    break;
                case PaymentType.BeveragesWorld:
                    organizationId = organizationParametersProvider.BeveragesWorldOrganizationId;
                    break;
                default:
                    throw new NotSupportedException($"Невозможно подобрать организацию, так как тип оплаты {order.PaymentType} не поддерживается.");
            }

            return uow.GetById<Organization>(organizationId);
        }

        private bool IsOnlineStoreOrder(Order order)
        {
            return order.OrderItems.Any(x => x.Nomenclature.OnlineStore != null && x.Nomenclature.OnlineStore.Id != orderParametersProvider.OldInternalOnlineStoreId);
        }
        
        private Organization GetOrganizationForOnlineStore(IUnitOfWork uow)
        {
            return uow.GetById<Organization>(organizationParametersProvider.VodovozSouthOrganizationId);
        }
        
        private Organization GetOrganizationForOtherOptions(IUnitOfWork uow, Order order)
        {
            int organizationId = 0;
            switch(order.PaymentType) {
                case PaymentType.barter:
                case PaymentType.cashless:
                case PaymentType.ContractDoc:
                    organizationId = organizationParametersProvider.VodovozOrganizationId;
                    break;
                case PaymentType.cash:
                case PaymentType.Terminal:
                case PaymentType.ByCard:
                    organizationId = organizationParametersProvider.VodovozSouthOrganizationId;
                    break;
                case PaymentType.BeveragesWorld:
                    organizationId = organizationParametersProvider.BeveragesWorldOrganizationId;
                    break;
                default:
                    throw new NotSupportedException($"Тип оплаты {order.PaymentType} не поддерживается, невозможно подобрать организацию.");
            }

            return uow.GetById<Organization>(organizationId);
        }
        
        public Organization GetOrganizationForOrderWithoutShipment(IUnitOfWork uow, OrderWithoutShipmentForAdvancePayment order)
        {
            if (uow == null) throw new ArgumentNullException(nameof(uow));
            if (order == null) throw new ArgumentNullException(nameof(order));

            int organizationId = organizationParametersProvider.VodovozOrganizationId;
            if(IsOnlineStoreOrderWithoutShipment(order)) {
                organizationId = organizationParametersProvider.VodovozSouthOrganizationId;
            }
            
            return uow.GetById<Organization>(organizationId);
        }
        
        private bool IsOnlineStoreOrderWithoutShipment(OrderWithoutShipmentForAdvancePayment order)
        {
            return order.OrderWithoutDeliveryForAdvancePaymentItems.Any(x => x.Nomenclature.OnlineStore != null && x.Nomenclature.OnlineStore.Id != orderParametersProvider.OldInternalOnlineStoreId);
        }
        
        public int GetMainOrganization()
        {
            return SingletonParametersProvider.Instance.GetIntValue("main_organization_id");
        }
    }
}