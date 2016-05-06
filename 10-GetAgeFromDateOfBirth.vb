'DateofBirth formatted like this 1992-06-26
Function GetAgeFromDOB(DateOfBirth As String) As String

  Dim dob As DateTime
	
	Dim arr As Array[String]
	DateOfBirth.Split("-", arr)   
	             
  	dob.Year = CInt(arr[0])
	dob.Month = CInt(arr[])
	dob.DayOfMonth = CInt(arr[2])
	
	dob.Hour = 0
	dob.Minute = 0
	dob.Second = 0

	dob.Normalize()
	
	Dim currentTime As DateTime = GetCurrentTime()
	Dim totalSecondsInAge As Integer = currentTime.TotalSeconds - dob.TotalSeconds
	
	GetAgeFromDOB = CStr(totalSecondsInAge / 31557600)
	
End Function


