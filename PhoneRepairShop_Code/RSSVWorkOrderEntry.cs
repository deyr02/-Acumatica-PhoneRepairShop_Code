using System;
using PX.Data;
using PX.Data.BQL.Fluent;

namespace PhoneRepairShop
{
  public class RSSVWorkOrderEntry : PXGraph<RSSVWorkOrderEntry>
  {

    //public PXSave<MasterTable> Save;
    //public PXCancel<MasterTable> Cancel;

        #region views
        public SelectFrom<RSSVWorkOrder>.View WorkOrder;
        public SelectFrom<RSSVWorkOrderItem>
            .Where<RSSVWorkOrderItem.orderNbr.IsEqual<RSSVWorkOrder.orderNbr.FromCurrent>>.View RepairItems;
        public SelectFrom<RSSVWorkOrderLabor>
            .Where<RSSVWorkOrderLabor.orderNbr.IsEqual<RSSVWorkOrder.orderNbr.FromCurrent>>.View Labor;
        #endregion


        public PXFilter<MasterTable> MasterView;
    public PXFilter<DetailsTable> DetailsView;

    [Serializable]
    public class MasterTable : IBqlTable
    {

    }

    [Serializable]
    public class DetailsTable : IBqlTable
    {

    }


  }
}