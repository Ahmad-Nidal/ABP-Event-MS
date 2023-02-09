namespace EMS.Permissions;

public static class EMSPermissions
{
    public const string GroupName = "EMS";

    public class Events
    {
        public const string Default = GroupName + ".Events";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
