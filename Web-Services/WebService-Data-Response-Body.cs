public class DepartmentReferenceDataResponseBody : BaseResponseBodyMultiple<DepartmentItem>
{
    public DepartmentReferenceDataResponseBody()
    { }

    public DepartmentReferenceDataResponseBody(DataRow[] rows)
    {
        PopulateArray(rows);
    }

    public override DepartmentItem Create(DataRow dr)
    {
        return new DepartmentItem(dr);
    }
}

public class GetAuditDataResponseBody : BaseResponseBodyMultiple<GetAuditDataItem>
{
    public GetAuditDataResponseBody()
    { }

    public GetAuditDataResponseBody(DataRow[] rows)
    {
        PopulateArray(rows);
    }

    public override GetAuditDataItem Create(DataRow dr)
    {
        return new GetAuditDataItem(dr);
    }
}