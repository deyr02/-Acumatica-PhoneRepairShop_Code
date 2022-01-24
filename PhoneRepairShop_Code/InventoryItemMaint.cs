using PhoneRepairShop;
using PX.Data;
using PX.Data.BQL.Fluent;

namespace PX.Objects.IN
{
    public class InventoryItemMaint_Extension : PXGraphExtension<InventoryItemMaint>
  {
    #region Event Handlers

  

        protected void _(Events.RowSelected<InventoryItem> e)
        {
            InventoryItem item = (InventoryItem)e.Row;
            InventoryItemExt itemExt = PXCache<InventoryItem>.GetExtension<InventoryItemExt>(item);
            bool enableFields = itemExt != null && itemExt.UsrRepairItem == true;

            //Make the Repair Item Type box available //when the Repair Item check box is selected.
            PXUIFieldAttribute.SetEnabled<InventoryItemExt.usrRepairItemType>(e.Cache, e.Row, enableFields);
            //Display the Compatible Devices tab when the Repair Item check box //is selected.

            CompatibleDevices.Cache.AllowSelect = enableFields;
        }

    
    #endregion

    public SelectFrom<RSSVStockItemDevice>.LeftJoin<RSSVDevice>
            .On<RSSVStockItemDevice.deviceID.IsEqual<RSSVDevice.deviceID>>
            .Where<RSSVStockItemDevice.inventoryID.IsEqual<InventoryItem.inventoryID.FromCurrent>>.View CompatibleDevices;
       
    }
}