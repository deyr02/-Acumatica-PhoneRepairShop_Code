using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneRepairShop.Helper
{
    class Constants
    {
        public static class RepairComplexity
        {
            public const string Low = "L";
            public const string Medium = "M";
            public const string High = "H";
        }

        public static class RepairItemTypeConstants 
        {
            public const string Battery = "BT";
            public const string Screen  = "SR";
            public const string ScreenCover = "SC";
            public const string BackCover = "BC";
            public const string Motherboard = "MB";
            
        }
        public static class WorkOrderStatusConstants 
        { 
            public const string OnHold = "OH"; 
            public const string PendingPayment = "PP"; 
            public const string ReadyForAssignment = "RA"; 
            public const string Assigned = "AS"; 
            public const string Completed = "CM"; 
            public const string Paid = "PD"; 
        }

        public static class WorkOrderPriorityConstants 
        { 
            public const string High = "H"; 
            public const string Medium = "M"; 
            public const string Low = "L"; 
        }

        //The fluent BQL constants for the work order statuses used in PXUIVisible
        public class workOrderStatusOnHold : PX.Data.BQL.BqlString.Constant<workOrderStatusOnHold> 
        { 
            public workOrderStatusOnHold() : base(WorkOrderStatusConstants.OnHold) { } 
        } 
        public class workOrderStatusReadyForAssignment : PX.Data.BQL.BqlString.Constant<workOrderStatusReadyForAssignment> 
        { 
            public workOrderStatusReadyForAssignment() : base(WorkOrderStatusConstants.ReadyForAssignment) { } 
        } 
        public class workOrderStatusPendingPayment : PX.Data.BQL.BqlString.Constant<workOrderStatusPendingPayment> 
        {
            public workOrderStatusPendingPayment() : base(WorkOrderStatusConstants.PendingPayment) { } 
        }
    }
}
