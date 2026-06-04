Module PolyhedronInUnitSphere
    Sub Main()
        ' All polyhedra are inscribed in a unit sphere (radius = 1)
        ' Edge lengths are derived from circumradius R = 1
        ' Formulas from spherical geometry / polyhedral math

        Dim polyhedra As New List(Of (name As String, faces As Integer, vertices As Integer, edges As Integer, surfaceArea As Double, volume As Double))

        ' 1. Tetrahedron (4 faces)
        ' Edge length a = √(8/3) ≈ 1.63299 when R=1
        Dim a_tetra = Math.Sqrt(8 / 3)
        Dim area_tetra = Math.Sqrt(3) * a_tetra * a_tetra
        Dim vol_tetra = a_tetra * a_tetra * a_tetra / (6 * Math.Sqrt(2))
        polyhedra.Add(("Tetrahedron", 4, 4, 6, area_tetra, vol_tetra))

        ' 2. Cube (Hexahedron) - 6 faces
        ' Diagonal = 2R = 2, so edge a = 2/√3 ≈ 1.1547
        Dim a_cube = 2 / Math.Sqrt(3)
        Dim area_cube = 6 * a_cube * a_cube
        Dim vol_cube = a_cube * a_cube * a_cube
        polyhedra.Add(("Cube", 6, 8, 12, area_cube, vol_cube))

        ' 3. Octahedron (8 faces)
        ' Vertices on axes: (±1,0,0), (0,±1,0), (0,0,±1)
        ' Edge length between adjacent vertices = √2
        Dim a_octa = Math.Sqrt(2)
        Dim area_octa = 2 * Math.Sqrt(3) * a_octa * a_octa
        Dim vol_octa = (4 / 3) * 1 * 1 * 1  ' Actually 4/3 * R³ for octahedron volume = 4/3
        polyhedra.Add(("Octahedron", 8, 6, 12, area_octa, vol_octa))

        ' 4. Dodecahedron (12 pentagonal faces)
        ' For R=1, edge length a = 2 / (√3 * φ) where φ = (1+√5)/2
        Dim phi = (1 + Math.Sqrt(5)) / 2
        Dim a_dodeca = 2 / (Math.Sqrt(3) * phi)
        Dim area_dodeca = 3 * Math.Sqrt(25 + 10 * Math.Sqrt(5)) * a_dodeca * a_dodeca
        Dim vol_dodeca = (15 + 7 * Math.Sqrt(5)) / 4 * a_dodeca * a_dodeca * a_dodeca
        polyhedra.Add(("Dodecahedron", 12, 20, 30, area_dodeca, vol_dodeca))

        ' 5. Icosahedron (20 triangular faces)
        ' For R=1, edge length a = 4 / √(10 + 2√5)
        Dim a_icosa = 4 / Math.Sqrt(10 + 2 * Math.Sqrt(5))
        Dim area_icosa = 5 * Math.Sqrt(3) * a_icosa * a_icosa
        Dim vol_icosa = (5 * (3 + Math.Sqrt(5))) / 12 * a_icosa * a_icosa * a_icosa
        polyhedra.Add(("Icosahedron", 20, 12, 30, area_icosa, vol_icosa))
        ' Display results
        For Each p In polyhedra
        Next
        ' Sphere for comparison
        Dim sphereArea = 4 * Math.PI * 1 * 1
        Dim sphereVolume = (4 / 3) * Math.PI * 1 * 1 * 1
        For Each p In polyhedra
        Next
    End Sub
End Module