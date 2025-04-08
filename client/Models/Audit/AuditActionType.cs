using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models.Audit
{
    public enum AuditActionType
    {
        Create,
        Update,
        Delete,
        Sale,
        Refund,
        InventoryAdjustment,
        PriceChange,
        Login,
        LoginFailure,
        Logout,
        SystemEvent,
        PasswordChange,
        PermissionChange,
        AccountLock,
        AccountUnlock,
        PasswordReset,
        BackupData,
        BackupDataFailure,
        CreateBackup,
        RestoreBackup
    }
}
