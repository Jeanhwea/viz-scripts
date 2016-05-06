function GetSubFolderNames(byval strPath as String) as Array[String]
	strPath = FormatPath(strPath)
	dim a_strSubFolderName as Array[String]
	if this.System.DirectoryExists(strPath) then
		dim a_strDirectoryContent as Array[String] = this.System.GetDirectoryContent(strPath, "*")
		for each strDirectoryContent in a_strDirectoryContent
			strDirectoryContent.Substitute("\\.", "", True)
			strDirectoryContent.Trim()
			if strDirectoryContent <> "" then
				if this.System.DirectoryExists(strPath & "/" & strDirectoryContent) then
					a_strSubFolderName.Push(strDirectoryContent)
				end if			
			end if
		next
	end if
	GetSubFolderNames = a_strSubFolderName
end function

function FormatPath(byval strPath as String) as String
	strPath.Trim()
	strPath.Substitute("\\\\", "/", True)
	do while strPath.EndsWith("/")
		strPath = strPath.GetSubString(0, strPath.Length - 1)
	loop
	strPath.Append("/")
	FormatPath = strPath
end function


