dim oldBool as boolean
dim oldColor as Color
dim oldContainer as Container
dim oldDouble as Double
dim oldInteger as Integer
dim oldString as String

sub OnInitParameters()
    dim plugins As Array[String]
    plugins.Push("Geometry")
    plugins.Push("Function")
    plugins.Push("Script")

    RegisterParameterContainer("Container", "Remote Container")
    RegisterRadioButton("Type", "Type", 0, plugins)
    RegisterParameterString("Plugin", "Plugin", "", 32, 100, "")
    RegisterParameterString("Parameter", "Parameter", "", 32, 100, "")

    dim types As Array[String]
    types.Push("Integer")
    types.Push("Double")
    types.Push("String")
    types.Push("Boolean")
    types.Push("Color")
    types.Push("Container")

    RegisterRadioButton("ParameterType", "Parameter Type", 0, types)    
end sub

sub OnGuiStatus()
    if GetParameterInt("Type") = 1 then
        SendGuiParameterShow("Plugin", SHOW)
    else
        SendGuiParameterShow("Plugin", HIDE)
    end if
end sub

sub OnParameterChanged(parameterName As String)
    dim c = GetParameterContainer("Container")
    if Not c.Valid then
        c = this
    end if

    dim plugin As PluginInstance
    select case GetParameterInt("Type")
        case 0
            plugin = c.Geometry.PluginInstance
        case 1
            plugin = c.GetFunctionPluginInstance(GetParameterString("Plugin"))
        case 2
            plugin = c.ScriptPluginInstance         
    end select  

    dim param = GetParameterString("Parameter")
    select case GetParameterInt("ParameterType")
        case 0
            oldInteger = plugin.GetParameterInt(param)
        case 1
            oldDouble = plugin.GetParameterDouble(param)
        case 2
            oldString = plugin.GetParameterString(param)
        case 3
            oldBool = plugin.GetParameterBool(param)
        case 4
            oldColor = plugin.GetParameterColor(param)
        case 5
            oldContainer = plugin.GetParameterContainer(param)
    end select
end sub

sub OnExecPerField()
    dim c = GetParameterContainer("Container")
    if Not c.Valid then
        c = this
    end if

    dim plugin As PluginInstance
    select case GetParameterInt("Type")
        case 0
            plugin = c.Geometry.PluginInstance
        case 1
            plugin = c.GetFunctionPluginInstance(GetParameterString("Plugin"))
        case 2
            plugin = c.ScriptPluginInstance         
    end select  

    dim changed = false
    dim param = GetParameterString("Parameter")
    select case GetParameterInt("ParameterType")
        case 0
            dim i = plugin.GetParameterInt(param)
            if i <> oldInteger then
                oldInteger = i
                changed = true
            end if
        case 1
            dim d = plugin.GetParameterDouble(param)
            if d <> oldDouble then
                oldDouble = d
                changed = true
            end if
        case 2
            dim s = plugin.GetParameterString(param)
            if s <> oldString then
                oldString = s
                changed = true
            end if
        case 3
            dim b = plugin.GetParameterBool(param)
            if b <> oldBool then
                oldBool = b
                changed = true
            end if
        case 4
            dim col = plugin.GetParameterColor(param)
            if col <> oldColor then
                oldColor = col
                changed = true
            end if
        case 5
            dim cont = plugin.GetParameterContainer(param)
            if cont <> oldContainer then
                oldContainer = cont
                changed = true
            end if
        end select

    if changed then
        ParameterChanged ()
    end if
end sub

sub ParameterChanged()
    'DO YOUR LOGIC HERE
    println "Parameter changed"
end sub

