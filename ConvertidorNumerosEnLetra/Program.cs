String[] unidades =
{
    "",
    "Cero",
    "Uno",
    "Dos",
    "Tres",
    "Cuatro",
    "Cinco",
    "Seis",
    "Siete",
    "Ocho",
    "Nueve",
};
String[] decenas =
{
    "Diez",
    "Veinte",
    "Treinta",
    "Cuarenta",
    "Cincuenta",
    "Sesenta",
    "Setenta",
    "Ochenta",
    "Noventa",
};
String[] especiales =
{
    "",
    "Once",
    "Doce",
    "Trece",
    "Catorce",
    "Quince",
    "Dieciseis",
    "Diecisiete",
    "Dieciocho",
    "Diecinueve",
};
String[] centenas =
{
    "",
    "Cientos",
    "Doscientso",
    "Trescientos",
    "Cuatrocientos",
    "Quinientos",
    "Seiscientos",
    "Setesientos",
    "Ochacientos",
    "Novecientos",
};

int numero;
    Console.WriteLine(" ingrese un numeero entre 0 y 999 : ");
while (true)
if (int.TryParse(Console.ReadLine(), out numero))
{
    if (numero >= 0 && numero <= 999)
    {
        string numeroEnLetras =
            convertirNumeroEnLetras(numero);
        Console.WriteLine($" el numero  {numero} en letras es  : {numeroEnLetras}");
    }
    else
    {
        Console.WriteLine(" el numero numero ingresado esta fuera del rango valido... ");
    }

    }
    else
    {
        Console.WriteLine(" entrada no valida. " + " por favor ingrese un numero validdo");
    }


    string convertirNumeroEnLetras(int numero)
    {
    if (numero == 0)
    {
        return "Cero";
    }

        String numeroEnLetras = "";

    // procesar las unidades de millar
    int unidadesDeMillar = numero / 1000;
    if (unidadesDeMillar > 0)
        if (unidadesDeMillar == 1)
            numeroEnLetras = " mil";
    {
        numeroEnLetras += unidades[unidadesDeMillar] + " mil ";
        numero %= 1000;
    }

    //procesar las centenas
    int partecentena = numero / 100;
    if (partecentena > 0)
    {
        numeroEnLetras += centenas[partecentena] + " ";
        numero %= 100;
    }

    // procesar las decenas y unidades
    if (numero >= 11 && numero <=19)
    {
        numeroEnLetras += especiales[numero - 10];
    }
    else
    {
        int Decenas =numero / 10;
        if (Decenas > 0)
        {
            numeroEnLetras += decenas[Decenas];
            if(numero % 10 > 0)
            {
                numeroEnLetras += "y" + unidades[numero % 10 ];
            }
        }
        else if(numero % 10 > 0)
        {
            numeroEnLetras += unidades[numero % 10];
        }
    }
        
        return numeroEnLetras;
    }

