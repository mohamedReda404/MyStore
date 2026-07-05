using Volo.Abp.Identity;

namespace AppStore;

public static class AppStoreConsts
{
    public const string DbTablePrefix = "App";
    public const string? DbSchema = null;
    public const string AdminEmailDefaultValue = IdentityDataSeedContributor.AdminEmailDefaultValue;
    public const string AdminPasswordDefaultValue = "1q2w3E*";
    public const int LengthName = 100;
    public const int LengthDescription = 300;
    //public const int LengthName = 60;
}
