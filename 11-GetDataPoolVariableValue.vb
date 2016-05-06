function GetDataPool(variable as string) as string
	variable.Trim()
	
	dim dp = Scene.GetScenePluginInstance("DataPool")
	dp.SetParameterString("DataRequest", variable)
	dim out = dp.GetParameterString("DataOutput")
	
	dim parts As Array[String]
	out.Split("=", parts)
	if parts.Size < 2 then
		exit function
	end if
	
	GetDataPool = out.GetSubstring(variable.Length + 1, out.Length - variable.Length - 3)
end function

