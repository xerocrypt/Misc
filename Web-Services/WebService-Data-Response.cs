public class DepartmentReferenceDataResponse : BaseResponse
{
    public DepartmentReferenceDataResponse()
    { }

    public DepartmentReferenceDataResponse(DepartmentReferenceDataResponseBody body, Query errors)
    : base(errors)
    {
        this._body = body;
    }

    private DepartmentReferenceDataResponseBody _body;

    [XmlElement("Body")]
    public DepartmentReferenceDataResponseBody Body
    {
        get { return _body; }
        set { _body = value; }
    }
}

public class GetAuditDataResponse : BaseResponse
{
    public GetAuditDataResponse()
    { }

    public GetAuditDataResponse(GetAuditDataResponseBody body, Query errors)
    : base(errors)
    {
        this._body = body;
    }

    private GetAuditDataResponseBody _body;

    [XmlElement("Body")]
    public GetAuditDataResponseBody Body
    {
        get { return _body; }
        set { _body = value; }
    }
}