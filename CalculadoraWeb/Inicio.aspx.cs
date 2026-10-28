using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraWeb
{

    public partial class Inicio : System.Web.UI.Page
    {

        // Inicializacion de variables globales

        float num1 = 0, num2 = 0, resultado = 0;

        // Funcion que asigna los valores a las variables desdse lo que se ingresa en los text box
        private void asignarValores()
        {
            float.TryParse(num1TB.Text, out num1);
            float.TryParse(num2TB.Text, out num2);
        }

        // Funcion para calcular 10 elevado a n
        private float diezX(float n)
        {
            float resultado = 1;

            for (int i = 0; i < n; i++)
            {
                resultado = resultado * 10;
            }

            return resultado;
        }

        // Funcion que calcula el ezponencial "e" elevado a exp
        private float exponencial(float exp)
        {
            float resultado = 1;
            float n = 1;

            for (int i = 1; i <= 20; i++) // Aca utilizo una aproximacion de 20 terminos nada mas, luego de ciertos
                                          // terminos el resultado se vuelve impreciso
            {
                n = n * exp / i;
                resultado = resultado + n;
            }

            return resultado;
        }

        // Funcion que asigna la operacion que se debe realizar y le asigna un valor a la variable
        // resultado, tras realizar dicha operacion
        private float radioButton()
        {
            if (sumaRB.Checked == true)
            {
                resultado = num1 + num2;
            }
            else if (restaRB.Checked == true)
            {
                resultado = num1 - num2;
            }
            else if (multiplicacionRB.Checked == true)
            {
                resultado = num1 * num2;
            }
            else if (divisionRB.Checked == true)
            {
                if (num2 != 0) // Validacion de que el numero divisor no sea 0
                {
                    resultado = num1 / num2;
                }
            }
            else if (cuadradoRB.Checked == true)
            {
                resultado = num1 * num1;
            }
            else if (exponencialRB.Checked == true)
            {
                resultado = exponencial(num1);
            }
            else if (diezXRB.Checked == true)
            {
                resultado = diezX(num1);
            }

            return resultado;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Funcion que se ejecuta al presionar el boton de =
        protected void igualB_Click(object sender, EventArgs e)
        {
            // Valida el primer numero
            if (float.TryParse(num1TB.Text, out num1) == false)
            {
                resultadoL.Text = "Ingrese un numero valido.";
                return; // Se repite hasta que sea valido
            }

            // Si alguna de las 4 operaciones basicas esta seleccionada, se valida el segundo numero tambien
            if (sumaRB.Checked == true || restaRB.Checked == true ||
                multiplicacionRB.Checked == true || divisionRB.Checked == true)
            {
                if (float.TryParse(num2TB.Text, out num2) == false)
                {
                    resultadoL.Text = "Ingrese el segundo numero valido.";
                    return;
                }
            }

            // Valida que se seleccione alguna operacion
            if (sumaRB.Checked == false && restaRB.Checked == false && 
                multiplicacionRB.Checked == false && divisionRB.Checked == false && 
                cuadradoRB.Checked == false && exponencialRB.Checked == false && diezXRB.Checked == false)
            {
                resultadoL.Text = "Seleccione la operacion a realizar.";
                return;
            }

            // Valida que el divisor no sea 0
            if (divisionRB.Checked && num2 == 0)
            {
                resultadoL.Text = "No se puede dividir con 0 como divisor.";
                return;
            }

            // La potencia al cuadrado, 10 elevado a n y exponencial necesitan solo el primer numero,
            // solo se muestra un resultado si solo se escribe el primer numero y el segundo campo queda vacio
            if (cuadradoRB.Checked == true || exponencialRB.Checked == true || diezXRB.Checked == true)
            {
                if (num2TB.Text == "")
                {
                    asignarValores();
                    resultadoL.Text = radioButton().ToString();
                }
                else
                {
                    resultadoL.Text = "La operacion seleccionada solo permite usar el primer numero.";
                }
            } 
            else
            {
                asignarValores();
                resultadoL.Text = radioButton().ToString();
            }
        
        }
    }
}