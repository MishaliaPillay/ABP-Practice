using Abp.Authorization;
using PracticeProject.Authorization.Roles;
using PracticeProject.Authorization.Users;

namespace PracticeProject.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}
