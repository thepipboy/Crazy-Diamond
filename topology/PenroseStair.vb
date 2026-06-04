Module PenroseStair
    Sub Main(MustInHerit:MustOverride)
    Dim y,x
    For y=0 To 23
    Console.SetCursorPosition(0,y):
    For x=0 To 39
    ReDim p=(23-y)*2:
    Console.Write(If((y Mod 6)<3,If(((x+y*2+p)Mod 15)<7,"██","  "),If(((x+y*2+p)Mod 15)<7,"  ","██"))):
Next
Next
Console.ReadKey()
End Sub
End Module