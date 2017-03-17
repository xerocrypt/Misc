public class DepartmentItem
{
    public DepartmentItem()
    { }

    public DepartmentItem(System.Data.DataRow dr)
    {
        DepartmentCode = dr["Code"].ToString();
        DepartmentName = dr["Rubric"].ToString();
    }
                
    public string DepartmentCode
    { get; set; }

    public string DepartmentName
    { get; set; }
}

public class GetAuditDataItem
{
    public GetAuditDataItem()
    { }

    public GetAuditDataItem(System.Data.DataRow dr)
    {
        DateViewed = dr["Added"].ToString();
        ReturnedVersion = dr["ReportVersion"].ToString();
        GeneratedAt = dr["Rubric"].ToString();
        UserName = dr["UserID"].ToString();
        UserDomain = dr["UserDomain"].ToString();
        UserSystem = dr["UserSystem"].ToString();
        OrgCode = dr["Code"].ToString();
        FirstDescription = dr["Rubric"].ToString();
        SiteCode = dr["Code"].ToString();
        SecondDescription = dr["Rubric"].ToString();
    }

    public string DateViewed
    { get; set; }

    public string ReturnedVersion
    { get; set; }

    public string GeneratedAt
    { get; set; }

    public string UserName
    { get; set; }

    public string UserDomain
    { get; set; }

    public string UserSystem
    { get; set; }

    public string OrgCode
    { get; set; }

    public string FirstDescription
    { get; set; }

    public string SiteCode
    { get; set; }

    public string SecondDescription
    { get; set; }
}

