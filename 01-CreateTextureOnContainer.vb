sub OnInitParameters()
    RegisterParameterString("path", "Path", "", 60, 1000, "")
    RegisterPushButton("refresh", "Refresh", 1)
end sub


sub OnExecAction(buttonId as Integer)
    dim path as string
    path = GetParameterString("path")

    this.createTexture(path)
end sub
