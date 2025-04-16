using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models.Audit
{
    public enum AuditEntityType
    {
        Product,
        Category,
        InventoryCategory,
        InventorySubCategory,
        Subcategory,
        Unit,
        UnitType,
        UnitMeasure,
        Discount,
        Inventory,
        Customer,
        Order,
        User,
        System,
        Role,
        Payment,
        Shipment,
        Delivery,
        Invoice,
        Subscription,
        Plan,
        Notification,
        Backup,
        Restore,
    }
}
