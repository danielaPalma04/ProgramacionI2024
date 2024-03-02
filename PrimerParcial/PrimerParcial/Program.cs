using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    public CuentaBancaria(double saldo, double saldoInicial)
    {
        saldo = saldoInicial;
    }

    public double ConsultarSaldo()
    {
        return saldo;
    }

    public void Depositar(double monto)
    {
        if (monto > 0)
        {
            saldo += monto;
            Console.WriteLine("Su depósito ha sido realizado. Su saldo es: {0}", saldo);
        }
        else
        {
            Console.WriteLine("El monto a depositar no puede ser 0");
        }
    }

    public void Retirar(double monto)
    {
        if (monto > 0 && monto <= saldo)
        {
            saldo -= monto;
            Console.WriteLine("Retiro realizado con éxito. Su nuevo saldo es: {0}", saldo);
        }
        else
        {
            Console.WriteLine("El monto a retirar no puede ser mayor a su saldo actual.");
        }
    }
}

public class CajeroAutomatico
{
    cuentaBancaria privada;

    public CajeroAutomatico(string CuentaBancaria, string cuenta)
    {
        this.cuenta = cuenta;
    }

    public void IniciarSesion()
    {
        Console.WriteLine("Bienvenido al cajero automático.");

        int opcion;
        do
        {
            Menu();
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ConsultarSaldo();
                    break;
                case 2:
                    Depositar();
                    break;
                case 3:
                    Retirar();
                    break;
                case 4:
                    Console.WriteLine("Gracias por usar el cajero automático.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Ingrese una opción del 1 al 4.");
                    break;
            }
        } while (opcion != 4);
    }

    private void Menu()
    {
        Console.WriteLine("\nSeleccione una operación:");
        Console.WriteLine("1. Consultar saldo");
        Console.WriteLine("2. Depositar dinero");
        Console.WriteLine("3. Retirar dinero");
        Console.WriteLine("4. Salir");
    }
}
