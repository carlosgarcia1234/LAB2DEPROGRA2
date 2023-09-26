
Module Module1
        Sub Main1()
            Dim Saludo As String = "BIENVENIDO A LABORATORIO2 HECHO POR CARLOS JOSÉ DE PROGRA ll"
            Console.WriteLine(Saludo)

            Dim NI As Integer
            Dim N2 As Integer

            Console.Write("Inserta el primer número: ")
            NI = Convert.ToInt32(Console.ReadLine())

            Console.Write("Inserta el segundo número: ")
            N2 = Convert.ToInt32(Console.ReadLine())

            If NI Mod N2 = 0 Then
                Console.WriteLine(N2 & " es un divisor de " & NI)
            ElseIf N2 Mod NI = 0 Then
                Console.WriteLine(NI & " es un divisor de " & N2)
            Else
                Console.WriteLine("Ninguno de los números es divisor del otro.")
            End If

            Console.ReadLine()

        End Sub


        Sub Main2()
            Try

                Console.WriteLine("Ingrese el promedio mensual de infracciones: ")
                Dim promedioMensual As Double = Double.Parse(Console.ReadLine())

                ' Calcular el promedio diario en diferentes jornadas
                Dim promedioMatutino As Double = (promedioMensual * 0.2) / 30
                Dim promedioTarde As Double = (promedioMensual * 0.35) / 30
                Dim promedioNocturno As Double = (promedioMensual * 0.45) / 30

                ' Imprimir resultados
                Console.WriteLine("Promedio diario de infracciones en la mañana: " & promedioMatutino.ToString("F2"))
                Console.WriteLine("Promedio diario de infracciones en la tarde: " & promedioTarde.ToString("F2"))
                Console.WriteLine("Promedio diario de infracciones en la noche: " & promedioNocturno.ToString("F2"))
            Catch ex As FormatException
                Console.WriteLine("Error de formato: Ingrese un valor numérico válido.")
            Catch ex As Exception
                Console.WriteLine($"Error inesperado: {ex.Message}")
            Finally
                Console.WriteLine("Presione Enter para salir...")
                Console.ReadLine()
            End Try


        End Sub

        Sub Main3()
            Try
                Console.WriteLine("DESARROLLO DE EJERCICIO HECHO POR CARLOS JOSÉ 1")
                Console.WriteLine()

                ' Solicitar al usuario la distancia en kilómetros, horas y minutos
                Console.Write("Ingrese la distancia en kilómetros: ")
                Dim distanciaKm As Double = Double.Parse(Console.ReadLine())

                Console.Write("Ingrese el tiempo en horas: ")
                Dim horas As Integer = Integer.Parse(Console.ReadLine())

                Console.Write("Ingrese el tiempo en minutos: ")
                Dim minutos As Integer = Integer.Parse(Console.ReadLine())

                ' Calcular el tiempo total en minutos
                Dim tiempoTotalMinutos As Integer = (horas * 60) + minutos

                ' Calcular la velocidad media en diferentes unidades
                Dim velocidadKmPorHora As Double = distanciaKm / horas
                Dim velocidadKmPorMinuto As Double = distanciaKm / tiempoTotalMinutos
                Dim velocidadKmPorSegundo As Double = distanciaKm / (tiempoTotalMinutos * 60)
                Dim velocidadMPorMinuto As Double = (distanciaKm * 1000) / tiempoTotalMinutos
                Dim velocidadMPorSegundo As Double = (distanciaKm * 1000) / (tiempoTotalMinutos * 60)

                ' Mostrar los resultados en consola
                Console.WriteLine("Velocidad media en Km/h: " & velocidadKmPorHora & " Km/h")
                Console.WriteLine("Velocidad media en Km/min: " & velocidadKmPorMinuto & " Km/min")
                Console.WriteLine("Velocidad media en Km/s: " & velocidadKmPorSegundo & " Km/s")
                Console.WriteLine("Velocidad media en m/min: " & velocidadMPorMinuto & " m/min")
                Console.WriteLine("Velocidad media en m/s: " & velocidadMPorSegundo & " m/s")

            Catch ex As FormatException
                Console.WriteLine("Error de formato: Ingrese un valor numérico válido.")
            Finally
                Console.WriteLine()
                Console.WriteLine("Presione Enter para salir...")
                Console.ReadLine()
            End Try
        End Sub



        Sub MAIN4()

            Try

                Dim random As New Random

                Dim num1 As Integer = random.Next()
                Dim num2 As Integer = random.Next()
                Dim num3 As Integer = random.Next()

                Console.WriteLine("Ingrese el primer número:")
                num1 = Convert.ToInt32(Console.ReadLine())

                Console.WriteLine("Ingrese el segundo número:")
                num2 = Convert.ToInt32(Console.ReadLine())

                Console.WriteLine("Ingrese el tercer número:")
                num3 = Convert.ToInt32(Console.ReadLine)

                Dim mayor As Integer = Math.Max(num1, Math.Max(num2, num3))
                Dim menor As Integer = Math.Min(num1, Math.Min(num2, num3))
                Dim medio As Integer = (num1 + num2 + num3 - mayor - menor)

                Console.WriteLine("Random: {0},{1},{2} ", num1, num2, num3)

                Console.WriteLine("El número mayor es: {0}", mayor)
                Console.WriteLine("El número medio es: {0}", medio)
                Console.WriteLine("El número menor es: {0}", menor)

                Console.WriteLine("Estudiante:")
                Console.WriteLine("CARLOS JOSÉ GARCIA SUAREZ")

                Console.ReadLine()

            Catch ex As Exception
                Console.WriteLine("SE DEBEN INGRESAR SOLO NÚMEROS")

            End Try

        End Sub

    End Module
