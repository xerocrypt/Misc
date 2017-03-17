[WebMethod(MessageName = "GetDepartmentReferenceData")]

// GetDepartmentReferenceData is the API name. DepartmentReferenceDataResponse is the returned data item.
public DepartmentReferenceDataResponse GetDepartmentReferenceData()
{
    LogStart();
    try
    {
	    // Calls the myWebServiceHelper.GetReferenceDataResponse Web Service helper. No parameters are passed to the method,
	    // as we simpy want a list of all department names and department codes.
        var response = myWebServiceHelper.GetReferenceDataResponse();
				
	    // Define items to be included in a log entry if query is successful.
        LogSuccess(String.Format("{0} items returned", response.Body.Items.Length));
        return response;
    }

    catch (Exception ex)
    {
        LogFailure(ex);
        throw;
    }
}

// Second Web Service API
// Visual Studio or IIS has a problem with 'GetAuditData' as a Web Method message. Changed it to 'GetAuditDataViewer'.
[WebMethod(MessageName = "GetAuditDataViewer")]
		
// GetAuditDataResponse is the returned data item. GetAuditData is the class name here, and it takes five input parameters.
// Might need to modify the input data types to be nullable.
public GetAuditDataResponse GetAuditData(string SpecimenID, string Department, int Days, DateTime StartDate, DateTime EndDate)
{
    LogStart();
    try
    {
        // Declare the response as the result from myWebServiceHelper.GetAuditResponse(). The five input parameters are passed to it.
        var response = WrrsHelper.GetAuditResponse(SpecimenID, Department, Days, StartDate, EndDate);
				
        // Define the data items to be included in a log entry if the query is successful.
        LogSuccess(String.Format("{0} items returned", response.Body.Items.Length));
        return response;
    }

    catch (Exception ex)
    {
        LogFailure(ex);
        throw;
    }
}
