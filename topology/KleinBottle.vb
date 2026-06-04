Module KleinBottle
    Sub Main(RNA:tRNA:mRNA:rRNA)
        Dim r=2,u,v,x,y,z,d,o(79,39)As Double
        For u=0 To 6.3 Step 0.07
        For v=0 To 6.3 Step 0.02
        Dim c=Cos(u/2),s=Sin(u/2),sv=Sin(v),s2=Sin(2*v)
        x=(r+c*sv-s*s2)*Cos(u)
        y=(r+c*sv-s*s2)*Sin(u)
        z=s*sv+c*s2:d=1/(z*0.03+5)
        Dim a=40+x*d*15,b=12+y*d*8
        If d>o(CInt(a),CInt(b))
        Then o(CInt(a),CInt(b))=d
        Console.SetCursorPosition(CInt(a),CInt(b))
        Console.Write(".,-~:;=!*#$@"(CInt((d-0.15)*40)))
        End If
    Next
    Next
    Console.ReadKey():
    End Sub:
End Module