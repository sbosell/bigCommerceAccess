﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BigCommerceAccess.Models.Product
{
	[ DataContract ]
	public class BigCommerceProduct : BigCommerceProductBase
	{
		[ DataMember( Name = "inventory_tracking" ) ]
		public InventoryTrackingEnum InventoryTracking { get; set; }

		[ DataMember( Name = "skus" ) ]
		public BigCommerceReferenceObject ProductOptionsReference { get; set; }

		public List< BigCommerceProductOption > ProductOptions { get; set; }

		public BigCommerceProduct()
		{
			this.ProductOptions = new List< BigCommerceProductOption >();
		}
	}

	public enum InventoryTrackingEnum
	{
		none,
		simple,
		sku
	}
}