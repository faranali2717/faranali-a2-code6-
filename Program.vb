Imports System.Console

Module Program
    Sub Main()
        Dim radius, pie, cir, area As Double
        pie = 3.14
        WriteLine("enter radius of circle")
        radius = ReadLine()
        area = 0.5 * 2 * pie * radius
        cir = radius * 2 * pie
        WriteLine("area is equal to: " & area)
        WriteLine("circumference is equal to: " & cir)
        ReadKey()


    End Sub
End Module
