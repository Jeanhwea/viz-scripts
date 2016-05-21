dim type = 0
dim radio_buttons As Array[string]
dim dirName as string
dim frames as integer

dim rotation_x As Array[string]
dim rotation_y As Array[string]
dim rotation_z As Array[string]
dim position_x As Array[string]
dim position_y As Array[string]
dim position_z As Array[string]


dim str = ""		
dim input as array[string]
dim data as array[string]
dim counter = 0
dim FilePath = ""
dim File as string

	radio_buttons.Push("  Geometry  ")
	radio_buttons.Push("  Camera  ")


sub OnInitParameters()

    RegisterFileSelector("text_file", "File", "", "", "") 
    RegisterParameterString("director", "director", "", 20, 20,"") 
	RegisterParameterInt("keyframes", "keyframes", 1, 0, 1000)
	RegisterPushButton("create_Keyframes", "  Create Keyframes  ", 1)	
	RegisterPushButton("delete_Keyframes", "  Delete Keyframes  ", 2)		
    RegisterRadioButton("import_type", "Import Type",  1, radio_buttons) 

end sub



sub OnParameterChanged(parameterName As String)

 Select Case parameterName
    Case "keyframes"
    frames = GetParameterInt("keyframes")
    Case "director"
    dirName = GetParameterString("director")
    Case "text_file"
    FilePath = GetParameterString("text_file")
    Case "import_type"
    type = GetParameterInt("import_type")
 End Select
end sub




sub OnExecAction(buttonId As Integer)

     Select Case buttonID 
     Case 1
	 delete_keyframes()	
	 create_keyframes()
	 Case 2
	 delete_keyframes()
     end select
end sub






sub create_keyframes()
	
	' FindOrCreateChannelOfObject(dirName & "$Position")
	' FindOrCreateChannelOfObject(dirName & "$Scaling")
	' FindOrCreateChannelOfObject(dirName & "$Rotation")	
	  system.LoadTextFile(FilePath, File)
	  File.split("\n", input) 
	  parse()

	
 for i=0 to frames

  Select Case type 
     Case 1
    'Add Keyframes and names on stage
	 stage.finddirector(dirName).FindChannel("Position").AddKeyframe(Cdbl(i)/50).Name = "" & i
	 stage.finddirector(dirName).FindChannel("Pan").AddKeyframe(Cdbl(i)/50).Name = "" & i
	 stage.finddirector(dirName).FindChannel("Twist").AddKeyframe(Cdbl(i)/50).Name = "" & i
	 stage.finddirector(dirName).FindChannel("Tilt").AddKeyframe(Cdbl(i)/50).Name = "" & i
	
    'Add values from arrays to each keyframe	
	 stage.finddirector(dirName).FindChannel("Pan").findKeyFrame("" & i).XyzValue = Cdbl(rotation_x[i])
	 stage.finddirector(dirName).FindChannel("Tilt").findKeyFrame("" & i).XyzValue = Cdbl(rotation_y[i])
	 stage.finddirector(dirName).FindChannel("Twist").findKeyFrame("" & i).XyzValue = Cdbl(rotation_z[i])
	
	 stage.finddirector(dirName).FindChannel("Position").findKeyFrame("" & i).XyzValue.x = Cdbl(position_x[i])
	 stage.finddirector(dirName).FindChannel("Position").findKeyFrame("" & i).XyzValue.y = Cdbl(position_y[i])
	 stage.finddirector(dirName).FindChannel("Position").findKeyFrame("" & i).XyzValue.z = Cdbl(position_z[i])*-1
	
	 Case 0
	 'Add Keyframes and names on stage
	 stage.finddirector(dirName).FindChannel("Position").AddKeyframe(Cdbl(i)/50).Name = "" & i
	 stage.finddirector(dirName).FindChannel("Rotation").AddKeyframe(Cdbl(i)/50).Name = "" & i
	
    'Add values from arrays to each keyframe	
	 stage.finddirector(dirName).FindChannel("Rotation").findKeyFrame("" & i).XyzValue.x = Cdbl(rotation_y[i])
	 stage.finddirector(dirName).FindChannel("Rotation").findKeyFrame("" & i).XyzValue.y = Cdbl(rotation_x[i])
	 stage.finddirector(dirName).FindChannel("Rotation").findKeyFrame("" & i).XyzValue.z = Cdbl(rotation_z[i])*-1
	
	 stage.finddirector(dirName).FindChannel("Position").findKeyFrame("" & i).XyzValue.x = Cdbl(position_x[i])
	 stage.finddirector(dirName).FindChannel("Position").findKeyFrame("" & i).XyzValue.y = Cdbl(position_y[i])
	 stage.finddirector(dirName).FindChannel("Position").findKeyFrame("" & i).XyzValue.z = Cdbl(position_z[i])*-1
	
  end select
 Next
end sub






sub delete_keyframes()

for i=0 to frames

	stage.finddirector(dirName).FindChannel("Position").findKeyFrame("" & i).delete()
	stage.finddirector(dirName).FindChannel("Pan").findKeyFrame("" & i).delete()
	stage.finddirector(dirName).FindChannel("Tilt").findKeyFrame("" & i).delete()
	stage.finddirector(dirName).FindChannel("Twist").findKeyFrame("" & i).delete()
	
	stage.finddirector(dirName).FindChannel("Rotation").findKeyFrame("" & i).delete()
Next
end sub





'****************************************************************************

sub parse()

		position_x.clear
		position_y.clear
		position_z.clear
		rotation_x.clear
		rotation_y.clear
		rotation_z.clear
		data.clear
    for i=0 to input.ubound
		data.clear
		str = input[i]
	if str <> "" then
		 str.split("/",data)
	     position_x.push(data[1])		   
	     position_y.push(data[2])
	     position_z.push(data[3])
		 rotation_x.push(data[4])		   
	     rotation_y.push(data[5])
	     rotation_z.push(data[6])
	
'		 println position_x[5]
'		 println position_y[5]
'		 println position_z[5]	
'		 println rotation_x[5]
'		 println rotation_y[5]
'		 println rotation_z[5]  
     end if
	next	
end sub














