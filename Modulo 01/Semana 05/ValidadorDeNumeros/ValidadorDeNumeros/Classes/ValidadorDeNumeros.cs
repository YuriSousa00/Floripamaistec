namespace validadorDeNumeros.Classes
{
    public static class ValidadorDeNumeros
    {
        public static bool EhNumeroPrimo(int numero)
        {
            int contador = 1;

            for (int n = 1; n < numero; n++)
            {
                if (numero % n == 0)
                {
                    contador = contador + 1;
                }
            }

            if (contador == 2)
            {
                return true;
            }

            return false;
        }

        public static string ParOuImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                return "Par";
            }

            return "Impar";
        }

        public static bool EhDivisivelPor(int dividendo, int divisor)
        {
            if (dividendo % divisor == 0)
            {
                return true;
            }

            return false;
        }
    }
}

