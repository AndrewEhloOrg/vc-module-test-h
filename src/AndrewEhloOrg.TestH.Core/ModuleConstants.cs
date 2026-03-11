using System.Collections.Generic;
using VirtoCommerce.Platform.Core.Settings;

namespace AndrewEhloOrg.TestH.Core;

public static class ModuleConstants
{
    public static class Security
    {
        public static class Permissions
        {
            public const string Access = "test-h:access";
            public const string Create = "test-h:create";
            public const string Read = "test-h:read";
            public const string Update = "test-h:update";
            public const string Delete = "test-h:delete";

            public static string[] AllPermissions { get; } =
            [
                Access,
                Create,
                Read,
                Update,
                Delete,
            ];
        }
    }

    public static class Settings
    {
        public static class General
        {
            public static SettingDescriptor TestHEnabled { get; } = new()
            {
                Name = "TestH.Enabled",
                GroupName = "TestH|General",
                ValueType = SettingValueType.Boolean,
                DefaultValue = false,
            };

            public static IEnumerable<SettingDescriptor> AllGeneralSettings
            {
                get
                {
                    yield return TestHEnabled;
                }
            }
        }

        public static IEnumerable<SettingDescriptor> AllSettings
        {
            get
            {
                return General.AllGeneralSettings;
            }
        }
    }
}
