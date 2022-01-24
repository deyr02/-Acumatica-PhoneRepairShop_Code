using System;
using PX.Data;
using PX.Data.BQL.Fluent;
using PX.Objects.IN;

namespace PhoneRepairShop
{
  public class RSSVRepairPriceMaint : PXGraph<RSSVRepairPriceMaint, RSSVRepairPrice>
  {

  


  
    public SelectFrom<RSSVRepairPrice>.View RepairPrices;


   public SelectFrom<RSSVRepairItem>
            .LeftJoin<InventoryItem>
            .On<InventoryItem.inventoryID.IsEqual<RSSVRepairItem.inventoryID.FromCurrent>>
            .Where<RSSVRepairItem.deviceID.IsEqual<RSSVRepairPrice.deviceID.FromCurrent>
                .And<RSSVRepairItem.serviceID.IsEqual<RSSVRepairPrice.serviceID.FromCurrent>>>.View RepairItems;


 


  }
}