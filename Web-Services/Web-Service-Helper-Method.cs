      
// The Web Service helper is declared as 'internal static' so it is not exposed to anything outside the program. All access is through
// the GetDepartmentReferenceData() API call.
internal static DepartmentReferenceDataResponse GetReferenceDataResponse()
{
    // We only need to call the stored procedure, which returns all the department names and department codes.
    // No search parameters are required.
    var deptIdentifiers = Global.DbConnectionInfoManager.ExecuteCommand(new SqlCommand
    {
        CommandText = "prGetDepartmentReferenceData",
        CommandType = CommandType.StoredProcedure
    });

	// Return the DepartmentReferenceDataResponse and whatever data items it contains.
    return new DepartmentReferenceDataResponse(new DepartmentReferenceDataResponseBody(deptIdentifiers.Tables[0].Select()), new Query());          
}

// Second Web Service helper
// Class name is GetAuditResponse(). Takes several stored procedure query parameters.
internal static GetAuditDataResponse GetAuditResponse(string SpecimenID, string Department, Int32 Days, DateTime StartDate, DateTime EndDate)
{
    // This is  the stored procedure command. Defines the stored procedure name and SQL command type.
    var commandAudit = new SqlCommand
    {
        CommandText = "prGetAuditData",
        CommandType = CommandType.StoredProcedure,
    };

    // Define search parameters and data types for the stored procedure
    var paramListAudit = new List<SqlParameter>
    {
        new SqlParameter
        {
            ParameterName = "@SpecimenID",
            Direction = ParameterDirection.Input,
            SqlDbType = SqlDbType.VarChar,
            Value = SpecimenID
        },
        new SqlParameter
        {
            ParameterName = "@Department",
            Direction = ParameterDirection.Input,
            SqlDbType = SqlDbType.VarChar,
            Value = Department
        },
        new SqlParameter
        {
            ParameterName = "@Days",
            Direction = ParameterDirection.Input,
            SqlDbType = SqlDbType.Int,
            Value = Days
        },
        new SqlParameter
        {
            ParameterName = "@StartDate",
            Direction = ParameterDirection.Input,
            SqlDbType = SqlDbType.DateTime,
            Value = StartDate
        },
        new SqlParameter
        {
            ParameterName = "@EndDate",
            Direction = ParameterDirection.Input,
            SqlDbType = SqlDbType.DateTime,
            Value = EndDate
        }
    };

    // Pass the search parameters to the stored procedure as an array.
    commandAudit.Parameters.AddRange(paramListAudit.ToArray());
			
	// Send the command and parameter array to the DBConnectionInfoManager class
    var dsAudit = Global.DbConnectionInfoManager.ExecuteCommand(commandAudit);
			
	// Return the GetAuditDataResponseBody, containing the data returned from the stored procedure to the GetAuditData API.
    return new GetAuditDataResponse(new GetAuditDataResponseBody(dsAudit.Tables[0].Select()), new Query());
}
        