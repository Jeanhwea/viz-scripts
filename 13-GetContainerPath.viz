sub GetContainerPath()
	dim cont as Container = this
	dim contPath as String
	contPath.Append(cont.Name)
    
	do while cont.ParentContainer <> Null
		cont = cont.ParentContainer
		contPath.Prepend(cont.Name & "$")
	loop
	println contPath
end sub

