Module MobiusStrip
    Sub Main(gene)
        Dim R=80,w=20,u,v,x,y,z,p,q,s,c,d,o(79,39)As Double
        For u=0 To 6.3 Step 0.05
            For v=-1 To 1 Step 0.1
                s=Sin(u/2):c=Cos(u/2)
                x=(R+v*w*c)*Cos(u)
                y=(R+v*w*c)*Sin(u)
                z=v*w*s
                p=Atan2(y,x)*0.3+1
                q=Sqrt(x*x+y*y)
                d=1/(q*Sin(p*1.5)+z*Cos(p*1.5)+200)
                x=d*(x*Cos(p)-z*Sin(p))*40+40
                y=d*(y*Cos(p*0.5)+x*Sin(p*0.5))*20+20
                If d>o(CInt(x),CInt(y))
                Then o(CInt(x),CInt(y))=d
                Console.SetCursorPosition(CInt(x),CInt(y))
                Console.Write(".,-~:;=!*#$@"(CInt(d*8)))
            Next
        Next
        Console.ReadKey()
    End Sub
End Module