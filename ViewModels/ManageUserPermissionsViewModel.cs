﻿using asdf.Data.Helpers;

public class ManageUserPermissionsViewModel
{
    public string UserId { get; set; }
    public string UserName { get; set; }
    public string PermissionValue { get; set; }
    public PaginatedList<ManageUserClaimViewModel> ManagePermissionsViewModel { get; set; }
}
