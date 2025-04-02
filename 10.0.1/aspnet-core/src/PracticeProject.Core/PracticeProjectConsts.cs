using PracticeProject.Debugging;

namespace PracticeProject;

public class PracticeProjectConsts
{
    public const string LocalizationSourceName = "PracticeProject";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "73741f9ac0b04bbe8db9f1c819becdfb";
}
