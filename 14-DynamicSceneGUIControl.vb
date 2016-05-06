Dim sceneId as String

sub OnInitParameters()
	RegisterParameterString("path", "Path", "", 50, 300, "")
	RegisterPushButton("load", " Load ", 0)
	RegisterPushButton("clear", " Clear ", 1)
	RegisterPushButton("restart", " Restart ", 2)
	RegisterPushButton("start", " Start ", 3)
	RegisterPushButton("continue", " Continue ", 4)
end sub

sub OnExecAction(buttonId As Integer)
	Select Case buttonId
		Case 0
			System.SendCommand("#" & (Texture.VizId + 1) & "*DYNAMIC*SUBSCENE*TYPE SET OTHER")
			System.SendCommand("#" & (Texture.VizId + 1) & "*DYNAMIC*SUBSCENE*SCENE SET " & GetParameterString("path"))
		Case 1
			System.SendCommand("#" & (Texture.VizId + 1) & "*DYNAMIC*SUBSCENE*SCENE CLEAR")
		Case 2
			sceneId = System.SendCommand("#" & (Texture.VizId + 1) & "*DYNAMIC*SUBSCENE*SCENE GET")
			System.SendCommand(sceneId & "*STAGE SHOW 0.0")
		Case 3

			sceneId = System.SendCommand("#" & (Texture.VizId + 1) & "*DYNAMIC*SUBSCENE*SCENE GET")
			System.SendCommand(sceneId & "*STAGE START")
		Case 4
			sceneId = System.SendCommand("#" & (Texture.VizId + 1) & "*DYNAMIC*SUBSCENE*SCENE GET")
			System.SendCommand(sceneId & "*STAGE CONTINUE")
	End Select
end sub






