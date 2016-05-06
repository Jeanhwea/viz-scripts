structure MyStruct
	id as integer
	value as string
end structure

function ParseData(str as string) As Array[MyStruct]
	dim result as Array[MyStruct]

	'First, let's split to items
	dim items as Array[String]
	str.TclSplit(items)

	for each i in items
		Dim elements as Array[String]
		i.TclSplit(elements)
		
		dim item as MyStruct
		item.id = CInt( elements[0] )
		item.value = elements[1]
		result.Push(item)
	next
	
	ParseData = result
end function



' *******************************************************************
' Example of data

dim str = "{1 A} {2 B} {3 C}"
dim data = ParseData(str)

for i = 0 to data.Size - 1
	println "id: " & data[i].id 
	println "value: " & data[i].value
next

