Module Module1

    Sub Main()
        'Dim StudentName As String
        'Dim StudentId As String
        'Dim StudentAge As Integer
        'Dim StudentAddress As String
        'Dim StuentCourse As String
        'Dim StudentName As String, StudentId As String, StudentAge As Integer
        Dim StudentNames, StudentIds, StudentAddress, StudentCourse As String, StudentAges As Integer
        'Assign values to variables
        Console.Write("Enter Student Name: ")
        StudentNames = Console.ReadLine()
        StudentIds = "1002"
        StudentAddress = "Kicukiro"
        StudentCourse = "OOP"
        StudentAges = 25
        Console.WriteLine("Names are :" & StudentNames)
        Console.WriteLine("Id is :" & StudentIds)
        Console.WriteLine("Address  is :" & StudentAddress)
        Console.WriteLine("Course  is :" & StudentCourse)
        Console.WriteLine("Age  is :" & StudentAges)
        Console.ReadLine()
    End Sub

End Module
