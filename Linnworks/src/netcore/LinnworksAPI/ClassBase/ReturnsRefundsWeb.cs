using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ReturnsRefundsWeb
	{
		public Int32 Row;

		public Guid pkOrderID;

		public String cShippingAddress;

		public DateTime dProcessedOn;

		public Double fPostageCost;

		public Double fTotalCharge;

		public Double PostageCostExTax;

		public Double Subtotal;

		public Double fTax;

		public Double TotalDiscount;

		public Double CountryTaxRate;

		public Int32 nOrderId;

		public String cCurrency;

		public String PostalTrackingNumber;

		public String cCountry;

		public String Source;

		public String PostalServiceName;

		public String PostalServiceCode;

		public String Vendor;

		public String ReferenceNum;

		public String SecondaryReference;

		public String ExternalReference;

		public String Address1;

		public String Address2;

		public String Address3;

		public String Town;

		public String Region;

		public String BuyerPhoneNumber;

		public String Company;

		public String SubSource;

		public String ChannelBuyerName;

		public String AccountName;

		public String cFullName;

		public String cEmailAddress;

		public String cPostCode;

		public DateTime dPaidOn;

		public String cBillingAddress;

		public String BillingName;

		public String BillingCompany;

		public String BillingAddress1;

		public String BillingAddress2;

		public String BillingAddress3;

		public String BillingTown;

		public String BillingRegion;

		public String BillingPostCode;

		public String BillingCountryName;

		public String BillingPhoneNumber;

		public String cItemNumber;

		public String cItemName;

		public Int32 pkReturnId;

		public String RowType;

		public String ReturnReference;

		public Double PendingRefundAmount;

		public DateTime LastDate;

		public String Reason;

		public String ChannelReason;

		public String ChannelReasonSec;

		public String Category;

		public Int32 ReturnQty;

		public Guid fkReturnLocationId;

		public Boolean Scrapped;

		public Int32? ScrapQty;

		public DateTime ReturnDate;

		public String Location;

		public String ItemNumber;

		public String ItemTitle;

		public Int32 NewQty;

		public String RefundReference;

		public Guid pkRefundRowId;

		public Double Amount;

		public DateTime CreateDate;

		public Int32 CancellationQuantity;

		public Guid fkOrderItemReturnId;

		public DateTime ActionDate;

		public PostSaleStatusType RefundStatus;
	} 
}