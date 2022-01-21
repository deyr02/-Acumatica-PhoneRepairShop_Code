using PX.Data;

namespace PX.Objects.IN
{
    public class InventoryItemMaint_Extension : PXGraphExtension<InventoryItemMaint>
  {
    #region Event Handlers

    protected void _(Events.RowSelected<InventoryItem> e)
    {
      
            InventoryItem item = e.Row;
            InventoryItemExt itemExt = PXCache<InventoryItem>.GetExtension<InventoryItemExt>(item);
            bool enableFields = itemExt != null && itemExt.UsrRepairItem == true;

            //Make the Repair item Type box available
            //When the Repair item check box is selected
            PXUIFieldAttribute.SetEnabled<InventoryItemExt.usrRepairItemType>(e.Cache, e.Row, enableFields);
      
    }

    

    #endregion
  }
}